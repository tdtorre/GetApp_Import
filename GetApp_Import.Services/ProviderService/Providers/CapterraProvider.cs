using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GetApp_Import.Data.DummyData;
using GetApp_Import.Domain;

namespace GetApp_Import.Services.ProviderService.Providers
{
    public class CapterraProvider : ProviderBase, ICapterraProvider
    { 
        public CapterraProvider()
            : base()
        {
            this.Source = SourceType.YamlFile;
        }

        /// <inheritdoc/>
        protected override async Task<IList<SaaSProduct>> Map(string path)
        {
            Console.WriteLine("Mapping products from Capterra File...");

            // Get a FileStream from the path (source)
            var file = await this.GetFileFromSource(path);

            // Extract products from the YAML file stream using the proper mapping for Capterra Product
            // Close file stream
            // Return the products list
            return ProductsDummyData.GetCapterraProducts();
        }
    }
}
