using System;
using System.Collections.Generic;
using System.Text;

namespace SCBUILDAPP.Models
{
    public class Builds
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Minerals { get; set; }
        public int Gas { get; set; }
        public int LimitAvilable { get; set; }
        public int LimitUsed { get; set; }
        public   List<Units> UnitsList { get; set; }
        public Builds()
        {

        }
        public Builds(Models.DbRealm.Builds build)
        {
            Id = build.Id;
            Name = build.Name;  
            Minerals = build.Minerals;
            Gas = build.Gas;
            LimitAvilable = build.LimitAvilable;    
            LimitUsed = build.LimitUsed;    
            foreach (var u in UnitsList)
            {
                build.UnitsList.Add(new DbRealm.Units(u));
            }

        }
    }
}
