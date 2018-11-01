#include "pch.h"
#include "Wrapper.h"
#include "winstring.h"
using namespace CXStoreEngagementSDKFeatures;

Wrapper::Wrapper()
{

} 
Windows::Foundation::IAsyncOperation<String^>^ Wrapper::RegisterService()
{
 
	StoreServicesEngagementManager^ engagementManager = StoreServicesEngagementManager::GetDefault();
	
	return create_async([&] {return create_task(engagementManager->RegisterNotificationChannelAsync()).then([&](StoreServicesNotificationChannelRegistrationResult^ result) {
		String ^ x = ref new String(result->ErrorCode.ToString()->Data());
		OutputDebugString((L"*****" + x + L"*****\n")->Data());
		x = ref new String(result->ErrorMessage->Data());
		OutputDebugString((L"*****" + x + L"*****\n")->Data());
		x = ref new String(result->NotificationChannelUri->Data());
		OutputDebugString((L"*****" + x + L"*****\n")->Data());
		return x;
	}); });
		 
	
}
Windows::Foundation::IAsyncOperation<bool>^ Wrapper::UnRegisterService()
{	
	StoreServicesEngagementManager^ engagementManager = StoreServicesEngagementManager::GetDefault();
	return create_async([&] {return concurrency::create_task(engagementManager->UnregisterNotificationChannelAsync()).then([&](bool result) {
		String ^ x = ref new String(result.ToString()->Data());
		OutputDebugString((L"*****" + x + L"*****\n")->Data());
		return result;
	}); });
}

Windows::Foundation::IAsyncOperation<String^>^ Wrapper::Status()
{
	 
	/*
	wchar_t * begin = L"testchars";
	uint32 length = wcslen(begin);
	WindowsCreateString(begin, length, &value);
	*/
	return create_async([] {return create_task([] {return ref new String(L"Status"); }); });
 }

String^ Wrapper::test()
{
	return ref new String(L"test");
}