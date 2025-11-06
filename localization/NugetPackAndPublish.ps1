$nuget = "nuget5.9.1.exe";
$localNugetRepository = ".\nugets";

$currentDirectory = (Get-Item -Path ".\").FullName
$csProjPath = "$currentDirectory\Integrations.Localization.csproj"

& $nuget pack $csProjPath -Properties Configuration=Release -OutputDirectory $localNugetRepository