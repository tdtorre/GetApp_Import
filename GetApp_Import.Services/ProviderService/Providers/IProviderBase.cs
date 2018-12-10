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

        Task Import(string source, IDataService dataService);
    }
}
