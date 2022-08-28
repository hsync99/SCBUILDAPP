using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Xml.Schema;
using SCBUILDAPP.Models;
using Xamarin.CommunityToolkit.ObjectModel;
namespace SCBUILDAPP.ViewModels
{
    public class CreateBuildPageViewModel : BaseViewModel
    {
        private string name;
        private List<Units> listofunits;
        private int minerals;
        private int gas;
        private int limitavilable;
        private int limitused;
        private bool supplydepot;
        private bool barracks;
        private bool factory;
        public bool Factory { get => factory; set => SetProperty(ref factory,value); }
        public bool Barracks { get => barracks; set => SetProperty(ref barracks,value); }
        public bool SupplyDepot { get => supplydepot; set => SetProperty(ref supplydepot, value); }
        public int Minerals { get => minerals; set => SetProperty(ref minerals,value); }
        public int Gas { get => gas; set => SetProperty(ref gas,value); }
        public int LimitAvilable { get => limitavilable; set => SetProperty(ref limitavilable, value); }
        public int LImitUsed { get => limitused; set => SetProperty(ref limitused,value); }
        private ObservableRangeCollection<Units> ucollection;
        

        public string Name { get => name; set => SetProperty(ref name, value); }
        public List<Units> ListOfUnits { get => listofunits; set => SetProperty(ref listofunits, value); }
        public ObservableRangeCollection<Units> UCollection { get => ucollection; set => SetProperty(ref ucollection,value); }
        public CreateBuildPageViewModel()
        {

            ListOfUnits = new List<Units>();
            UCollection = new ObservableRangeCollection<Units>();
            LimitAvilable = 15;
        }
        public async void OnAppearing()
        {
            
        }

        public void AddUnitInList(string Name,int GasCost,int MineralCost,int LimitCost,double BTime,int LimitGives)
        {
            LimitAvilable = LimitAvilable + LimitGives;
            if (LimitAvilable > LImitUsed && Barracks == true && Name != "Tank" && Name != "Thor")
            {
                LImitUsed = LImitUsed + LimitCost;
                if (LimitAvilable >= LImitUsed)
                {
                    Minerals = Minerals + MineralCost;
                    Gas = Gas + GasCost;
                    var id = Guid.NewGuid().ToString();
                    ListOfUnits.Add(new Units { BuildTime = BTime, Name = Name, GasCost = GasCost, MineralCost = MineralCost, LimitCost = LimitCost, Id = id });
                    UCollection.ReplaceRange(ListOfUnits);
                }
                else
                {
                    LImitUsed=LImitUsed- LimitCost;
                }
            }
           
        }
        public void AddSupplyInList(string Name, int GasCost, int MineralCost, int LimitCost, double BTime, int LimitGives)
        {
            SupplyDepot = true;
            LimitAvilable = LimitAvilable + LimitGives;
            
               
                
                    Minerals = Minerals + MineralCost;
                    Gas = Gas + GasCost;
                    var id = Guid.NewGuid().ToString();
                    ListOfUnits.Add(new Units { BuildTime = BTime, Name = Name, GasCost = GasCost, MineralCost = MineralCost, LimitCost = LimitCost, Id = id });
                    UCollection.ReplaceRange(ListOfUnits);
                
                
            

        }
        public void AddBarracksInList(string Name, int GasCost, int MineralCost, int LimitCost, double BTime, int LimitGives)
        {
            if(SupplyDepot == true)
            {
                Barracks = true;
                LimitAvilable = LimitAvilable + LimitGives;
                Minerals = Minerals + MineralCost;
                Gas = Gas + GasCost;
                var id = Guid.NewGuid().ToString();
                ListOfUnits.Add(new Units { BuildTime = BTime, Name = Name, GasCost = GasCost, MineralCost = MineralCost, LimitCost = LimitCost, Id = id });
                UCollection.ReplaceRange(ListOfUnits);
            }
           




        }
        public void AddFactoryInList(string Name, int GasCost, int MineralCost, int LimitCost, double BTime, int LimitGives)
        {
            if (Barracks == true)
            {
                Factory = true;
                LimitAvilable = LimitAvilable + LimitGives;
                Minerals = Minerals + MineralCost;
                Gas = Gas + GasCost;
                var id = Guid.NewGuid().ToString();
                ListOfUnits.Add(new Units { BuildTime = BTime, Name = Name, GasCost = GasCost, MineralCost = MineralCost, LimitCost = LimitCost, Id = id });
                UCollection.ReplaceRange(ListOfUnits);
            }





        }


    }
}
