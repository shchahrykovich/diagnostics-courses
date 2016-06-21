@echo off

echo ===
echo Index pdbs
set TERM=msys

FOR /f "tokens=*" %%G IN ('git log -1 --format^=%%H') DO (set git_commit="%%G")

powershell github-sourceindexer.ps1 -symbolsFolder '%~dp0..\bin\' -gitHubUrl 'https://raw.githubusercontent.com/shchahrykovich/diagnostics-courses' ^
	   -commit %git_commit%  -sourcesRoot '%~dp0..\..\' ^
	   -dbgToolsPath 'C:\debuggers' -ignoreUnknown True