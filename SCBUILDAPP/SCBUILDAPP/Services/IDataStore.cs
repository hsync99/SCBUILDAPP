using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SCBUILDAPP.Services
{
    public interface IDataStore
    {
        Task<bool> CreateBuildAsync(Models.Builds build);
        Task<bool> CreateUnitAsync(Models.Units unit);

    }
}
