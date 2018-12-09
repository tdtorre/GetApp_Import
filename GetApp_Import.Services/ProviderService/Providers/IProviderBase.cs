using GetApp_Import.Domain;
using GetApp_Import.Services.DataService;
using System.Collections.Generic;

namespace GetApp_Import.Services.ProviderService.Providers
{
    public interface IProviderBase
    {
        SourceType Source { get; set; }

        List<SaaSProduct> Products { get; }

        void Import(string source, IDataService dataService);
    }
}
