using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
//using CXStoreEngagementSDKFeatures;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace uwpApplicationBase
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            StorageFolder appInstalledFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
            StorageFolder assets = await appInstalledFolder.GetFolderAsync("Assets");
            var files = await assets.GetFilesAsync();

            foreach (StorageFile sf in files)
            {
                Status.Text += "\n" + sf.Path;
            }
            /*
            MSAAuth ma = new MSAAuth();
            ma.BaseUri = this.BaseUri;
            ma.Auth();
            
            Wrapper storeSdk = new Wrapper();
            string s = await storeSdk.Status();
            string t = await storeSdk.RegisterService();
            Status.Text += "\n" + t +"\n"+s;
            */
        }

        private async void Unregister_Click(object sender, RoutedEventArgs e)
        {/*
            Wrapper storeSdk = new Wrapper();
            bool s = await storeSdk.UnRegisterService();
            Status.Text += "\n" + s + "\n" ;
            */
        }
    }


}
