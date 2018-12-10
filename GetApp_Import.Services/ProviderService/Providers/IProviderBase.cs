using GetApp_Import.Domain;
using GetApp_Import.Services.DataService;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GetApp_Import.Services.ProviderService.Providers
{
    public interface IProviderBase
    {
        SourceType Source { get; set; }

        IList<SaaSProduct> Products { get; }

        /// <summary>
        /// Import products from the file path to the database
        /// </summary>
        /// <param name="path">Feed File path</param>
        /// <param name="dataService">Data base connection service</param>
        /// <returns></returns>
        Task Import(string path, IDataService dataService);
    }
}
