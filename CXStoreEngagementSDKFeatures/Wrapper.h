#pragma once
using namespace concurrency;

namespace CXStoreEngagementSDKFeatures
{
    public ref class Wrapper sealed
    {
    public:
		Wrapper();
	public:
		Windows::Foundation::IAsyncOperation<String^>^ RegisterService();
		Windows::Foundation::IAsyncOperation<bool>^ UnRegisterService();
		Windows::Foundation::IAsyncOperation<String^>^Status();
		String^ test();
    };
}
