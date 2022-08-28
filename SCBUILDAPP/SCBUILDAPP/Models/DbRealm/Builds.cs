using System;
using System.Collections.Generic;
using System.Text;
using Realms;
namespace SCBUILDAPP.Models.DbRealm
{
    public  class Builds:RealmObject
    {
      public  int Id { get; set; }
        public string Name { get; set; }
        public int Minerals { get; set; }
        public int Gas { get; set; }
        public int LimitAvilable { get; set; }
        public int LimitUsed { get; set; }
      public  IList<Units> UnitsList { get; }
        public Builds()
        {

        }
        public Builds(Models.Builds builds)
        {
            Id = builds.Id;
            Name = builds.Name;
            Minerals = builds.Minerals; 
            Gas = builds.Gas;
            LimitAvilable = builds.LimitAvilable;   
           LimitUsed    = builds.LimitUsed; 
            foreach (var u in UnitsList)
            {
                builds.UnitsList.Add(new Models.Units(u));
            }
        }
    }
}
