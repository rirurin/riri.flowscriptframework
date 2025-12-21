using System.Runtime.InteropServices;

namespace riri.flowscriptframework.Types.V4;

// P5 Debug: frMsgInfo
[StructLayout(LayoutKind.Explicit, Size = 0x98)]
public unsafe struct MessageContext
{
    [FieldOffset(0x0)] public int X;
    [FieldOffset(0x4)] public int Y;
    [FieldOffset(0x8)] public int Z;
    [FieldOffset(0xc)] public byte Style;
    [FieldOffset(0xd)] public byte ColNo;
    [FieldOffset(0xe)] public byte Tp;
    [FieldOffset(0xf)] public byte Spd;
    [FieldOffset(0x20)] public nint Msg;
    [FieldOffset(0x28)] public MessageText* Text;
    [FieldOffset(0x30)] public int Offsets;
    [FieldOffset(0x38)] public byte FrqFlag;
    [FieldOffset(0x39)] public byte RetFlag;
    [FieldOffset(0x3a)] public ushort AlphaDelay;
    [FieldOffset(0x3c)] public uint Color;
    [FieldOffset(0x40)] public uint MsgReqResult;
    [FieldOffset(0x44)] public uint TagLevel;
}

// P5 Debug: _FRQ
[StructLayout(LayoutKind.Explicit, Size = 0x60)]
public unsafe struct MessageText
{
    [FieldOffset(0x0)] public short AlphaDelay;
    [FieldOffset(0x4)] public int X;
    [FieldOffset(0x8)] public int Y;
    [FieldOffset(0xc)] public int WidthPx;
    [FieldOffset(0x10)] public int XSize;
    [FieldOffset(0x14)] public int YSize;
    [FieldOffset(0x20)] public long Count;
    [FieldOffset(0x28)] public MessageCharacter* First;
    [FieldOffset(0x30)] public MessageCharacter* Last;

    public override string ToString()
    {
        if (Count == 0) return "<EMPTY>";
        var Current = First;
        string Out = "";
        while (Current != null)
        {
            Out += Current->ToString();
            Current = Current->Next;
        }

        return Out;
    }
}

// P5 Debug: _TEXT
[StructLayout(LayoutKind.Explicit, Size = 0x60)]
public unsafe struct MessageCharacter
{
    [FieldOffset(0x0)] public fixed byte Character[8];
    [FieldOffset(0x14)] public uint Color;
    [FieldOffset(0x20)] public MessageCharacter* Prev;
    [FieldOffset(0x28)] public MessageCharacter* Next;

    public override string ToString()
    {
        fixed (byte* pCharacter = Character)
        {
            return Marshal.PtrToStringUTF8((nint)pCharacter)!;
        }
    }
}