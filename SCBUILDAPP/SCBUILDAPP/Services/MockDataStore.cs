using SCBUILDAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Realms;
using SCBUILDAPP.Models;
namespace SCBUILDAPP.Services
{
    public class MockDataStore : IDataStore
    {
        public MockDataStore()
        {       
        }
        public async Task<bool> CreateBuildAsync(Builds build)
        {
            Builds b = new Builds();
            b = build;
            try
            {
                using (Realm realm = Realm.GetInstance())
                {
                    realm.Write(() =>
                    {
                        realm.Add(new Models.DbRealm.Builds(b), true);
                    });
                }

            }
            catch (Exception ex)
            {
                return false;
            }
            await Task.CompletedTask;
            return b != null ? true : false;
          
        }

        public async Task<bool> CreateUnitAsync(Units unit)
        {

            Units u = new Units();
            u = unit;
            try
            {
                using (Realm realm = Realm.GetInstance())
                {
                    realm.Write(() =>
                    {
                        realm.Add(new Models.DbRealm.Units(u), true);
                    });
                }

            }
            catch (Exception ex)
            {
                return false;
            }
            await Task.CompletedTask;
            return u != null ? true : false;
        }
    }
}