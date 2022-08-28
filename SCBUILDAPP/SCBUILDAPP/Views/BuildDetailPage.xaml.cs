using SCBUILDAPP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SCBUILDAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuildDetailPage : ContentPage
    {
        public BuildDetailPageViewModel vm;
        public BuildDetailPage()
        {
            InitializeComponent();
            vm = (BuildDetailPageViewModel)this.BindingContext;
        }
        protected async void OnAppearing()
        {
            base.OnAppearing();
            vm.OnAppearing();
        }
    }
}