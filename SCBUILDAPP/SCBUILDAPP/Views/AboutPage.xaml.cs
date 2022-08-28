using SCBUILDAPP.ViewModels;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SCBUILDAPP.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutViewModel vm;
        public AboutPage()
        {
            InitializeComponent();
            vm = (AboutViewModel)this.BindingContext;
        }       
        protected async void OnAppearing()
        {
            base.OnAppearing();
            vm.OnAppearing();
        }

       
    }
}