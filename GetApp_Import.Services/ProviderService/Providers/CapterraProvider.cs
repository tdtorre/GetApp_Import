using System.Collections.Generic;
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

        protected override IList<SaaSProduct> Map(string source)
        {
            // Get a FileStream from the path (source)
            var file = this.GetFileFromSource(source);

            // Extract products from the YAML file stream using the proper mapping for Capterra Product
            // Close file stream
            // Return the products list
            return ProductsDummyData.GetCapterraProducts();
        }
    }
}
