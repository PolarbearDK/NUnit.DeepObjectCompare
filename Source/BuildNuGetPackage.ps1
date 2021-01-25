param (
	[switch]$Pack = $true,
	[switch]$Push
)

Set-StrictMode -Version latest
$ErrorActionPreference = "Stop"

if($pack) {
  & dotnet build --configuration Release
	if(!$?){throw "dotnet build returned exit code $LASTEXITCODE"}
  dotnet vstest ((ls -Recurse *.Test?.dll | % FullName) -Match "\\bin\\Release\\")
	if(!$?){throw "dotnet test returned exit code $LASTEXITCODE"}
}

if($push) {
	$filename = Get-ChildItem ".\NUnit.DeepObjectCompare\bin\Release\NUnit.DeepObjectCompare.*" | Sort-Object LastWriteTime -Descending | Select -First 1
	echo "Pushing $filename"
  & .NuGet\NuGet.exe push "$filename" -Source https://api.nuget.org/v3/index.json
}
