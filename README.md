# WinStoreSDKCPP
Implement Windows Store Services SDK with CPP

If you just want to verify the service notification function, suggest to follow step 1, 2, 3, in CSharp project to quickly see results:
[Configure your app for targeted push notifications](https://docs.microsoft.com/en-us/windows/uwp/monetize/configure-your-app-to-receive-dev-center-notifications)

Prerequisite

[Install store services sdk](https://docs.microsoft.com/en-us/windows/uwp/monetize/microsoft-store-services-sdk)

Suppose a general C++ project already has one C++ Win32 App, one UWPFeatures dll for proxying UWP APIs, one Package project for packing Win32 App to UWP app. 

Here is the project link:

https://github.com/freistli/WinStoreSDKCPP

Now here are five projects:

1.	CXStoreEngagementSDKFeatures  CPP WinRT component, used for registering notification by using Store Service SDK
2.	UWPFeatures CPP UWP Feature Library, provides calls to CXStoreEngagementSDKFeatures and other standard UWP APIs. 
3.	CPPClient  CPP Win32 Client, use LoadLibrary to call UWPFeatures functions
4.	CPPToUWP Package Project to pack CPP Client as UWP app
5.	uwpApplicationBase A tool uwp, used to locate CXStoreEngagementSDKFeatures  for CPPClient because by default Win32 cannot use custom WinRT component

To build, select Debug|X64 in CentennnialTest solution, and associate your live Windows Store App item in CPPToUWP for registering notification by using Store Service SDK. Run it, and then can test the Notification function in Dev Center.

Refer to https://blogs.windows.com/buildingapps/2017/07/06/calling-winrt-components-win32-process-via-desktop-bridge/ to get ideas of how to use in-process customized WinRT Component with Win32 project, and improve it with 
[VS Package Project template](https://docs.microsoft.com/en-us/windows/uwp/porting/desktop-to-uwp-packaging-dot-net)
