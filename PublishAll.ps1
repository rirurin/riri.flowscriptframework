# Set Working Directory
Split-Path $MyInvocation.MyCommand.Path | Push-Location
[Environment]::CurrentDirectory = $PWD

./Publish.ps1 -ProjectPath "p3rpc.flowscriptframework/p3rpc.flowscriptframework.csproj" -PackageName "p3rpc.flowscriptframework" -PublishOutputDir "Publish/P3R/Main/ToUpload"
./Publish.ps1 -ProjectPath "p3rpc.flowscriptframework.dumper/p3rpc.flowscriptframework.dumper.csproj" -PackageName "p3rpc.flowscriptframework.dumper" -PublishOutputDir "Publish/P3R/Dumper/ToUpload"
./Publish.ps1 -ProjectPath "p3rpc.flowscriptframework.test/p3rpc.flowscriptframework.test.csproj" -PackageName "p3rpc.flowscriptframework.test" -PublishOutputDir "Publish/P3R/Test/ToUpload"