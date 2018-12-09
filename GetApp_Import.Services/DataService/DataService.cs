using System;
using GetApp_Import.Domain;

namespace GetApp_Import.Services.DataService
{
    public abstract class DataService : IDataService
    {
        public string DataClientName { get; set; }

        public abstract void Create(SaaSProduct product);

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
