### Solution for Nancy memory leak

#### Task 1

Launch the WebApp.exe application from the [bin](bin/) folder. Run the [MakeRequests.bat](bin/MakeRequests.bat). Take 2 memory dumps a few seconds apart.

You can take memory dumps with a help of Task Manager or you can use procdump.exe from the [tools](../tools/) folder. `procdump -ma -n 2 -s 15 WebApp` this command creates 2 memory dumps of WebApp application 15 seconds apart.

#### Task 2

Open the first memory dump in WinDbg. Load SOS extension and print out managed heap statistics:
```
!loadby sos clr
!DumpHeap -stat
```
Now repeat these steps for the second dump and compare two tables.
![Heap stat for 2 dumps](img/HeapStatFor2Dumps.PNG)

### References
[Hidden catch when using linked CancellationTokenSource](https://lowleveldesign.wordpress.com/2015/11/30/catch-in-cancellationtokensource)

[Github changeset](https://github.com/NancyFx/Nancy/commit/7d70fed4c1dbd9bd530564c4e06a178ed2e19ef6)