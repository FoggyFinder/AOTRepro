1. `dotnet publish -c Release -p:Platform=x64`
2. `...\AOTRepro\bin\x64\Release\net8.0-windows10.0.19041.0\win-x64\native>AOTRepro`
   
```
Unhandled Exception: System.DllNotFoundException: Unable to load DLL 'Microsoft.WindowsAppRuntime.dll' or one of its dependencies: Не найден указанный модуль.
   at System.Runtime.InteropServices.NativeLibrary.LoadLibErrorTracker.Throw(String) + 0x6f
   at Internal.Runtime.CompilerHelpers.InteropHelpers.FixupModuleCell(InteropHelpers.ModuleFixupCell*) + 0xfd
   at Internal.Runtime.CompilerHelpers.InteropHelpers.ResolvePInvokeSlow(InteropHelpers.MethodFixupCell*) + 0x2f
   at Microsoft.Windows.Foundation.UndockedRegFreeWinRTCS.NativeMethods.WindowsAppRuntime_EnsureIsLoaded() + 0x24
   at Microsoft.Windows.Foundation.UndockedRegFreeWinRTCS.AutoInitialize.AccessWindowsAppSDK() + 0x3e
   at Internal.Runtime.CompilerHelpers.StartupCodeHelpers.RunInitializers(TypeManagerHandle, ReadyToRunSectionType) + 0x39
   at Internal.Runtime.CompilerHelpers.StartupCodeHelpers.RunModuleInitializers() + 0x36
   at AOTRepro!<BaseAddress>+0x254fc3
```
