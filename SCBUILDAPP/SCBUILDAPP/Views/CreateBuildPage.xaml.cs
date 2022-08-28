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
    public partial class CreateBuildPage : ContentPage
    {
        public CreateBuildPageViewModel vm;
        public CreateBuildPage()
        {
            InitializeComponent();
            vm=(CreateBuildPageViewModel)this.BindingContext;
        }
        protected async void OnAppearing()
        {
            base.OnAppearing();
            vm.OnAppearing();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void marineCreate(object sender, EventArgs e)
        {
            
            vm.AddUnitInList("Marine", 0, 50, 1, 25.0,0);
        }

        private void ReaperCreate(object sender, EventArgs e)
        {
            vm.AddUnitInList("Reaper", 50, 50, 1, 32.0,0);
        }

        private void SupplyCreate(object sender, EventArgs e)
        {
            vm.AddSupplyInList("Supply", 0, 100, 0, 21, 8);
        }
        private void BarracksCreate(object sender, EventArgs e)
        {
            vm.AddBarracksInList("Barracks", 0, 150, 0, 46, 0);
        }
        private void FactoryCreate(object sender, EventArgs e)
        {

        }
    }
}