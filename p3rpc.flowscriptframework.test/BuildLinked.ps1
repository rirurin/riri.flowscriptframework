# Set Working Directory
Split-Path $MyInvocation.MyCommand.Path | Push-Location
[Environment]::CurrentDirectory = $PWD

Remove-Item "$env:RELOADEDIIMODS/p3rpc.flowscriptframework.test/*" -Force -Recurse
dotnet publish "./p3rpc.flowscriptframework.test.csproj" -c Release -o "$env:RELOADEDIIMODS/p3rpc.flowscriptframework.test" /p:OutputPath="./bin/Release" /p:ReloadedILLink="true"

# Restore Working Directory
Pop-Location