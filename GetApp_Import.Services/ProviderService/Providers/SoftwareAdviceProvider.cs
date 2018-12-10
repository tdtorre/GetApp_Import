using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GetApp_Import.Data.DummyData;
using GetApp_Import.Domain;

namespace GetApp_Import.Services.ProviderService.Providers
{
    public class SoftwareAdviceProvider : ProviderBase, ISoftwareAdviceProvider
    {
        public SoftwareAdviceProvider()
            : base()
        {
            this.Source = SourceType.YamlFile;
        }

        /// <inheritdoc/>
        protected override async Task<IList<SaaSProduct>> Map(string path)
        {
            Console.WriteLine("Mapping products from Software Advisor File...");

            // Get a FileStream from the path (source)
            var file = await this.GetFileFromSource(path);

            // Extract products from the YAML file stream using the proper mapping for Software Advisor Product
            // Close file stream
            // Return the products list
            return ProductsDummyData.GetSoftwareAdvisorProducts();
        }
    }
}
