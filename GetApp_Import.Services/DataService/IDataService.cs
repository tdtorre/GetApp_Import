using GetApp_Import.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GetApp_Import.Services.DataService
{
    public interface IDataService : IDisposable
    {
        string DataClientName { get; set; }

        Task<bool> Create(SaaSProduct product);
    }
}
