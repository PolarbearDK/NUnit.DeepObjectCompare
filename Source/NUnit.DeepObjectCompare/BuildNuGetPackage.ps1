param (
	[switch]$Pack = $true,
	[switch]$Push
)

Set-StrictMode -Version latest
$ErrorActionPreference = "Stop"

if($pack) {
	& msbuild NUnit.DeepObjectCompare.csproj /p:Configuration=release
	if(!$?){throw "msbuild returned exit code $LASTEXITCODE"}
	
	& ..\.NuGet\NuGet.exe pack NUnit.DeepObjectCompare.csproj -prop Configuration=release
	if(!$?){throw "NuGet returned exit code $LASTEXITCODE"}
}

if($push) {
	$filename = Get-ChildItem "NUnit.DeepObjectCompare.*" | Sort-Object LastWriteTime -Descending | Select -First 1
	echo "Pushing $filename"
	& ..\.NuGet\NuGet.exe push "$filename" -Source https://www.nuget.org/api/v2/package
}
