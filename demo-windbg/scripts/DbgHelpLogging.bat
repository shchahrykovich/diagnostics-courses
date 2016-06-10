rem msdn.microsoft.com/en-us/library/windows/desktop/ms680687.aspx

md c:\Symbols
md c:\Symbols\DbgHelp

setx DBGHELP_DBGOUT 1
setx DBGHELP_LOG C:\Symbols\DbgHelp\DbgHelpLog.txt