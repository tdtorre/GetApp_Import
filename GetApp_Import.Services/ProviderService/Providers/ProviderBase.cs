using System;
using System.Collections.Generic;
using System.IO;
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

        public void Import(string source, IDataService dataService)
        {
            this.Products = this.Map(source);
            this.PersistData(dataService);

            Console.WriteLine("Import completed");
        }

        protected virtual StreamReader GetFileFromSource(string sourcePath)
        {
            //var reader = new StreamReader(sourcePath);
            var reader = StreamReader.Null;
            return reader;
        }

        protected void PersistData(IDataService dataService)
        {
            Console.WriteLine($"Importing products to database ({dataService.DataClientName})...");

            foreach (var product in this.Products)
            {
                try
                {
                    dataService.Create(product);
                    Console.WriteLine("Import " + product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"There was a problem trying to import '{product.Name}' product. (ERROR: " + ex.Message + ")");
                }
            }
        }

        protected abstract IList<SaaSProduct> Map(string source);
    }
}
