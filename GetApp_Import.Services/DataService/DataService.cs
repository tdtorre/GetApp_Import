using System;
using System.Threading.Tasks;
using GetApp_Import.Domain;

namespace GetApp_Import.Services.DataService
{
    public abstract class DataService : IDataService
    {
        public string DataClientName { get; set; }

        /// <inheritdoc/>
        public abstract Task<bool> Create(SaaSProduct product);

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
