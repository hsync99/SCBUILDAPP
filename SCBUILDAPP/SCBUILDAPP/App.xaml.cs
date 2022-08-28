using SCBUILDAPP.Services;
using SCBUILDAPP.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SCBUILDAPP
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTQ2MzQ4QDMxMzkyZTMzMmUzMERNWVlQNkdBdTlaVUtaTFE2ZS9pWnJQSGxXMHliaXVtZGVSdkZPWmFRc1U9");
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
