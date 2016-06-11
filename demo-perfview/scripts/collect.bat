@echo off

set hr=%time:~0,2%
if "%hr:~0,1%" equ " " set hr=0%hr:~1,1%

%~dp0/../tools/PerfView.exe collect %~dp0/%COMPUTERNAME%_%date:~-4,4%-%date:~-10,2%-%date:~-7,2%_%hr%-%time:~3,2%.etl ^
		   -BufferSizeMB:512 -CircularMB:4096 -Merge:True -Zip:True -NoGui -NoNGenRundown -AcceptEULA