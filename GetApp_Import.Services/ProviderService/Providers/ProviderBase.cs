using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using GetApp_Import.Domain;
using GetApp_Import.Services.DataService;

namespace GetApp_Import.Services.ProviderService.Providers
{
    public abstract class ProviderBase : IProviderBase
    {
        public ProviderBase()
        {
            this.Products = new List<SaaSProduct>();
            this.Source = SourceType.Unknown;
        }

        public SourceType Source { get; set; }

        public IList<SaaSProduct> Products { get;  protected set; }

        public async Task Import(string source, IDataService dataService)
        {
            this.Products = await this.Map(source);
            await this.PersistData(dataService);

            Console.WriteLine("Import completed");
        }

        protected virtual Task<StreamReader> GetFileFromSource(string sourcePath)
        {
            //var reader = new StreamReader(sourcePath);
            var reader = StreamReader.Null;
            return Task.FromResult(reader);
        }

        protected async Task PersistData(IDataService dataService)
        {
            Console.WriteLine($"Importing products to database ({dataService.DataClientName})...");

            foreach (var product in this.Products)
            {
                try
                {
                    await dataService.Create(product);
                    Console.WriteLine("Import " + product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"There was a problem trying to import '{product.Name}' product. (ERROR: " + ex.Message + ")");
                }
            }
        }

        protected abstract Task<IList<SaaSProduct>> Map(string source);
    }
}
