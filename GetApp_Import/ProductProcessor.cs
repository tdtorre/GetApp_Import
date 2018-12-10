using GetApp_Import.Services.DataService;
using GetApp_Import.Services.ProviderService;
using System.Threading.Tasks;

namespace GetApp_Import
{
    public static class ProductProcessor
    {
        public static async Task Execute(string source, string path, IDataService dataService)
        {
            // Get the proper provider and execute product import
            var provider = ProviderFactory.GetProvider(source);
            await provider.Import(path, dataService);
        }
    }
}
