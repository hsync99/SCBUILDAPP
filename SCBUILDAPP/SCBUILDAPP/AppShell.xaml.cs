using SCBUILDAPP.ViewModels;
using SCBUILDAPP.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SCBUILDAPP
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(CreateBuildPage), typeof(CreateBuildPage));
        }

    }
}
