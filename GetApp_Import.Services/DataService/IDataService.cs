using GetApp_Import.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GetApp_Import.Services.DataService
{
    public interface IDataService : IDisposable
    {
        string DataClientName { get; set; }

        void Create(SaaSProduct product);
    }
}
