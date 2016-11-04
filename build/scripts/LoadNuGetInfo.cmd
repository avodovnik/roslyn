@echo off

REM This is a script that will set environment information about where to find
REM NuGet.exe, it's version and ensure that it's present on the enlistment.
set NuGetExeVersion=3.6.0-beta1
set NuGetExeFolder=%~dp0..\..
set NuGetExe=%NuGetExeFolder%\NuGet.exe

REM If we have an applocal copy of MSBuild, pass it to NuGet.  Otherwise, assume NuGet knows how to find it.
if exist "%DevenvDir%\..\..\MSBuild\15.0\Bin\MSBuild.exe" (
    set NuGetAdditionalCommandLineArgs=-verbosity quiet -configfile "%NuGetExeFolder%\nuget.config" -Project2ProjectTimeOut 1200 -msbuildpath "%DevenvDir%\..\..\MSBuild\15.0\Bin"
) else (
    set NuGetAdditionalCommandLineArgs=-verbosity quiet -configfile "%NuGetExeFolder%\nuget.config" -Project2ProjectTimeOut 1200
)

REM Download NuGet.exe if we haven't already
if not exist "%NuGetExe%" (
    echo Downloading NuGet %NuGetExeVersion%
    powershell -noprofile -executionPolicy Bypass -file "%~dp0download-nuget.ps1" "%NuGetExeVersion%" "%NuGetExeFolder%" || goto :DownloadNuGetFailed
)

