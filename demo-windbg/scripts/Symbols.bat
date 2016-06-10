@echo off

md C:\Symbols
md C:\Symbols\Src
md C:\Symbols\LocalCache
md C:\Symbols\Local
md C:\Symbols\SymCache

compact /c /s /i /q C:\Symbols\LocalCache
compact /c /s /i /q C:\Symbols\SymCache

::echo Hello > C:\Symbols\LocalCache\index2.txt

setx /M _NT_SOURCE_PATH SRV*C:\Symbols\Src
setx /M _NT_SYMBOL_PATH SRV*C:\Symbols\LocalCache*http://msdl.microsoft.com/download/symbols;SRV*c:\Symbols\LocalCache*http://srv.symbolsource.org/pdb/Public;c:\Symbols\Local
setx /M _NT_SYMCACHE_PATH C:\Symbols\SymCache