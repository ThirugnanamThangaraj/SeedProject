@ECHO OFF
@SETLOCAL
@SET CHAINEDCALL=true
@SET MODE=Debug
@FOR %%A IN (%*) DO @IF "%%A"=="nochain" @SET CHAINEDCALL=false
@FOR %%A IN (%*) DO @IF "%%A"=="Release" @SET MODE=Release

@SET SOLU="..\..\src\MBRepositoryService\MBRepositoryHost\MBRepositoryHost.csproj"
@SET PROFILE=%cd%\..\..\src\MBRepositoryService\MBRepositoryResourceTemplate\bin\%MODE%\staging\MBRepositoryResourceTemplate\MBRepositoryHost

  
@SET MSBUILDDIR=C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\15.0\Bin


@ECHO Merrill Bridge Seed Service Host Publishing to folder in %MODE% mode..
@SET StartTime=%Time%
@"%MSBUILDDIR%\msbuild.exe" %SOLU% /p:Platform=AnyCPU;Configuration=%MODE%;PackageFileName=%PROFILE%\package.zip /t:Rebuild;Package /clp:ErrorsOnly /fl /flp:ErrorsOnly;WarningsOnly
@SET EndTime=%Time%
@SET BUILD_STATUS=%ERRORLEVEL% 
@IF not %BUILD_STATUS%==0 goto fail 
@ECHO Build Start: %StartTime%
@ECHO Build End:   %EndTime%
@ECHO.


@Del %PROFILE%\*.txt
@Del %PROFILE%\*.cmd
@Del %PROFILE%\*.xml

@IF NOT "%CHAINEDCALL%"=="true" PAUSE
@ENDLOCAL
@GOTO End

:fail 
@EXIT /b 1 

:End
