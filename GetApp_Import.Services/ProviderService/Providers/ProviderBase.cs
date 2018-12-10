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

        /// <inheritdoc/>
        public async Task Import(string path, IDataService dataService)
        {
            Console.WriteLine($"Importing products from '{path}'");

            this.Products = await this.Map(path);
            await this.PersistData(dataService);

            Console.WriteLine("Import completed");
        }

        /// <summary>
        /// Get a Stream Reader based on the file path
        /// </summary>
        /// <param name="path">File path</param>
        /// <returns></returns>
        protected virtual Task<StreamReader> GetFileFromSource(string path)
        {
            //var reader = new StreamReader(sourcePath);
            var reader = StreamReader.Null;
            return Task.FromResult(reader);
        }

        /// <summary>
        /// Store the products loaded from the file to database
        /// </summary>
        /// <param name="dataService">Data base connection service</param>
        /// <returns></returns>
        protected async Task PersistData(IDataService dataService)
        {
            Console.WriteLine($"Storing products to database ({dataService.DataClientName})...");

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

        /// <summary>
        /// Map all the products from the file to Products collection
        /// </summary>
        /// <param name="path">File path</param>
        /// <returns></returns>
        protected abstract Task<IList<SaaSProduct>> Map(string path);
    }
}
