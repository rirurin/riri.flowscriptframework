# Flowscript Framework for Persona 3 Reload

A framework that allows mod authors to edit and add new FlowScript and MessageScript functions. Additionally, they can call flowscript functions from within code mods.

This is inspired by similar mods that already exist for P5R. See [Credits](#credits) for more information.

## Usage

For reference, an example mod (`p3rpc.flowscriptframework.test`) is available which provides examples for the use cases described below.

There are two main interfaces from Flowscript Framework: `IFlowFramework` and `IMsgFramework`. 
To obtain these in your own mod, download `p3rpc.flowscriptframework.Interfaces` from NuGet and add `p3rpc.flowscriptframework.Interfaces` into your `ModConfig.json`.
They'll then be accessible from `IModLoader.GetController<ControllerType>`:

```c#
var flowLibLoaded = _modLoader.GetController<IFlowFramework>().TryGetTarget(out var flowLib);
var msgLibLoaded = _modLoader.GetController<IMsgFramework>().TryGetTarget(out var msgLib);
```

### Adding FlowScript Functions

`IFlowFramework` contains a function `Register` which can either override an existing function when `idOverride` is set or create a new function:
```c#
    public void Register(string functionName, ParamType[] args, ParamType returnArg,
        Func<IScriptState, FlowStatus> function, ushort idOverride = ushort.MaxValue);
```

- `functionName` is what the function will be called. \
A warning will be printed if it's name conflicts with another function name ([it doesn't neccessarily have to be the same name!](#technical-details)), rename it if this happens.
- `args` defines what input parameters the function will have. \
The following parameter types are supported:
    - Integer (`ParamType.Int`)
    - Float (`ParamType.Float`)
    - String (`ParamType.String`)
- `returnArg` defines the type for the output parameter. In addition to the types listed above, `ParamType.Void` is valid here.
- `function` is a callback to a C# function which contains the custom function. \
When making a custom FlowScript function, parameters can be retrieved from `IScriptState`'s context using `GetIntArg`, `GetFloatArg` or `GetStringArg`.  \
FlowScript's return value is set using `SetReturnValue`, while C#'s return value is either `FlowStatus.SUCCESS` or `FlowStatus.FAILURE`.

The following function adds a custom function to retrieve the square of the input.
```c#
flowLib.Register("SQUARE", [ParamType.Int], ParamType.Int, ctx =>
{
    var num = ctx.GetIntArg(0);
    ctx.SetReturnValue(num * num);
    return FlowStatus.SUCCESS;
});
```

### Using the Dumper

A dumper mod (`p3rpc.flowsrarycriptframework.dumper`) is included which will generate a wrapper class for every FlowScript function and a custom [AtlusScriptTools](https://github.com/tge-was-taken/Atlus-Script-Tools) library which will let AST use custom functions. \
Settings to adjust what target library to use (this should stay as `Persona3Reload`) and the namespace that the wrapper class is contained in can be set and the dumper will trigger when these settings are saved or when the config window (Configure Mod) is closed.

The generated AST library is placed inside Dumps (e.g For Persona3Reload, it will be in the folder `Dumps/Persona3Reload`). This can be copied into AST.

### Restore Print Functionality

An option is available within the main mod's config to toggle FlowScript's logging functions, which are `PUT`, `PUTF`, `PUTS`, `DBG_PUT` and `DBG_PUTS`. In the vanilla game, these functions do nothing but this option restores their logging ability and can print their input parameter into the Reloaded console.

```c
// In FlowScript
PUT(10); // Print an integer
PUTF(0.5); // Print a float
PUTS("test"); // Print a string
DBG_PUT(20); // Also prints an integer
DBG_PUTS("dbg test"); // Also prints a string
```

### Calling Flowscript Functions

New and existing FlowScript functions can be called either from code or from a FlowScript script (BF):

#### From Code

`IFlowFramework` contains the functions `InvokeInt`, `InvokeFloat` and `InvokeVoid` to call functions which have those return types.\
Parameters are passed in by defining an instance of `IntParam`, `FloatParam` or `StringParam`:

```c#
var Res = flowLib.InvokeInt("GET_COUNT", [new IntParam(i)]);
```

If you've generated a wrapper class for your project, you can call it as if it were a regular C# method:

```c#
var Res = wrapper.GET_COUNT(i);
```

#### From FlowScript

Once a AtlusScriptTools library is created with the custom functions, they can be called from a FlowScript file:

```c
var3 = 0;
while (var3 < 25) {
    PUT(SQUARE(var3));
    var3++;
}
```

This will compile correctly if the custom functions are defined in AST's library. In game, this will print squares of numbers 0-24.
This example is available in the test mod in `BF_NPC_002_280.uasset`, which will be called when talking to Fuuka in the dorm's lounge.

### Adding MessageScript Functions

Much like `IFlowFramework`, `IMsgFramework` includes a `Register` function to create a new MessageScript function:

```c#
    public void Register(string functionName, List<MessageParam> arguments,
        Func<IMessageState, bool> function, ushort idOverride = ushort.MaxValue);
```
The parameters are mostly the same as in FlowLib, but there are a couple differences:
- `arguments` accepts a list of `MessageParams`, which gives each parameter a defined name and description that will appear when it's
dumped as an AST library. \
MessageScript parameters are always `short`, so there's no need for a type definition in this case.
- If `function` returns true, no more tokens (text or functions) will be processed.

```c#
MsgLib.Register("rgb", 
    [new("red"), new("green"), new("blue")], 
    ctx =>
    {
        if (ctx.GetTagLevel() == 5 || ctx.GetTagLevel() < 1)
            ctx.SetColor(Color.FromArgb(0xff, ctx.GetArg(0), ctx.GetArg(1), ctx.GetArg(2)));
        return false; // Return false so text doesn't get cut off
    }
);
```
Creates a new MessageScript tag which sets the color of text to an arbitrary RGB value. The implementation of this is like the built-in color function, but with an RGB value instead of a preset.

### Calling MessageScript Functions

Much like with FlowScript, custom MessageScript functions can be used within MessageScript files (BMD).

The example used in the test mod edits `BMD_CampSystem` to change the color of text when opening a save file to green:

```
[msg SYS_SAVE_LOAD_CHECK]
[f 2 1][rgb 0 255 0]Load [rgb 0 224 32]this [rgb 0 192 64]save [rgb 0 160 96]data?[n][f 1 4 1][w][e] 
```

### Technical Details

#### Limits to Adding New Functions

The ID of a Flowscript function is a `u16` which is broken down into two parts: A Section Id for the top 4 bits (0-15) and a Function Id for the bottom 28 bits (0-4095). \
For example, `FLD_CAMERA_LOCK_INTERP` has the ID (`0x205d`), which is section 0x2 and function 0x5d. This normally means that the FlowScript context will check the *third* entry in the section table, then the 94th entry in it's function table. \
Section and function tables are stored in the executable and so are limited in their length, but custom FlowScript functions use a dynamic lookup system which allows for a function to have any arbitrary `u16`. This means that there's an absolute limit of **64651 new functions**. \
In practice, this number is *slightly* lower since functions are added into the lookup system using a hash of it's name. While hash collisions on vanilla functions are handled by rehashing since they're constant, collisions on custom functions are not allowed since a rehash could vary depending on what mods or what order the mod user has their mods in.

A similar situation exists with MessageScript but will be more appearent since function IDs are stored as a `u8`, limiting the max function count (including existing functions) to 256.

#### How Calling FlowScript from C# Works

In order to call a FlowScript function in C#, a new FlowScript interpreter context has to be created which involves `malloc`ing and setting appropriate values. This introduces a lot of overhead, so it should not be used for high-performance code. \
In that situation, I would recommend either making a wrapper to the underlying function and calling that or to rewrite the function.

## Credits

- **[p5rpc.flowscriptframework](https://github.com/Secre-C/p5rpc.flowscriptframework/)** (GPL-3.0) by **Secre-C** ([Github](https://github.com/Secre-C), [Bluesky](https://bsky.app/profile/secrec.bsky.social))
- **[p5rpc.lib](https://github.com/animatedSwine37/p5rpc.lib)** (GPL-3.0) by **AnimatedSwine37** ([Github](https://github.com/AnimatedSwine37), [Bluesky](https://bsky.app/profile/animatedswine.bsky.social))