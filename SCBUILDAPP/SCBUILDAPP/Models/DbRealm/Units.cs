using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCBUILDAPP.Models.DbRealm
{
    public  class Units:RealmObject
    {
        public string Id { get; set; } 
        public string Name { get; set; }    
        public string Description { get; set; } 
        public int MineralCost { get; set; } 
        public int GasCost { get; set; }
        public int LimitCost { get; set; }
        public double BuildTime { get; set; }
        public Units()
        {

        }
        public Units(Models.Units units)
        {
            Id = units.Id;
            Name = units.Name;
            Description = units.Description;
            MineralCost = units.MineralCost;
            GasCost = units.GasCost;
            LimitCost = units.LimitCost;
            BuildTime = units.BuildTime;
        }
    }
}
