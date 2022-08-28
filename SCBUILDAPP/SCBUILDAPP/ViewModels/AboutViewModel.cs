using SCBUILDAPP.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SCBUILDAPP.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            GoToCreateBuildPageCommand = new Command(GoToCreateBuildPage);
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
        public ICommand GoToCreateBuildPageCommand { get; }
        public async void OnAppearing()
        {
            
        }
        public async void GoToCreateBuildPage()
        {
            await Task.FromResult(Xamarin.Forms.Shell.Current.GoToAsync($"{nameof(CreateBuildPage)}"));
        }
    }
}