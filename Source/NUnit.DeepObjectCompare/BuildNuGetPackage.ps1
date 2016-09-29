param (
	[switch]$Pack = $true,
	[switch]$Push
)

Set-StrictMode -Version latest
$ErrorActionPreference = "Stop"

if($pack) {
	& msbuild NUnit.DeepObjectCompare.csproj /p:Configuration="Release 4.5"
	if(!$?){throw "msbuild returned exit code $LASTEXITCODE"}
	& msbuild NUnit.DeepObjectCompare.csproj /p:Configuration="Release 4.5.2"
	if(!$?){throw "msbuild returned exit code $LASTEXITCODE"}
	& msbuild NUnit.DeepObjectCompare.csproj /p:Configuration="Release 4.6"
	if(!$?){throw "msbuild returned exit code $LASTEXITCODE"}
	
	& ..\.NuGet\NuGet.exe pack NUnit.DeepObjectCompare.csproj -Verbosity detailed -Properties Configuration="Release 4.5.2"
	if(!$?){throw "NuGet returned exit code $LASTEXITCODE"}
}

if($push) {
	$filename = Get-ChildItem "NUnit.DeepObjectCompare.*" | Sort-Object LastWriteTime -Descending | Select -First 1
	echo "Pushing $filename"
	& ..\.NuGet\NuGet.exe push "$filename" -Source https://www.nuget.org/api/v2/package
}
