echo

SET PATH=C:\Program Files (x86)\Microsoft Visual Studio 10.0\Common7\IDE\mstest;%PATH%

:TEST
echo Running tests...
del /S %2
mstest /testcontainer:%1 /resultsfile:%2
echo Test run completed.
IF ERRORLEVEL 0 goto TRANSFORM
echo The MSTEST pass produced one or more errors in test results.
SET ERRORLEVEL=1
exit

:TRANSFORM
echo Applying XSL transformation to results...
tools\msxsl %2 %3 -o %4
echo Finished transformation.
IF ERRORLEVEL 0 goto INSPECT
echo The XSL transformation of test results caused an error.
SET ERRORLEVEL=1
exit

:INSPECT
echo Inspecting results for errors...
tools\inspecttrx.exe %2
echo Finished inspecting results.

:END
exit
