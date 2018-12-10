using GetApp_Import.Domain;
using System;
using System.Threading.Tasks;

namespace GetApp_Import.Services.DataService
{
    public interface IDataService : IDisposable
    {
        string DataClientName { get; set; }

        /// <summary>
        /// Save the product into database
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        Task<bool> Create(SaaSProduct product);
    }
}
