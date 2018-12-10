using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GetApp_Import.Data.DummyData;
using GetApp_Import.Domain;

namespace GetApp_Import.Services.ProviderService.Providers
{
    public class CsvFileProvider : ProviderBase, ICsvFileProvider
    {
        public CsvFileProvider()
            : base()
        {
            this.Source = SourceType.CsvFile;
        }

        protected override async Task<IList<SaaSProduct>> Map(string source)
        {
            Console.WriteLine("Mapping products from CSV File...");

            // Download and save the file from URL
            var filePath = await this.DownloadFileFromUrl(source);

            // Get a FileStream from the path (source)
            var file = await this.GetFileFromSource(filePath);

            // Extract products from the CSV file stream using the proper mapping for this Product Provider
            // Close file stream
            // Return the products list
            return ProductsDummyData.GetCsvFileProducts();
        }

        private async Task<string> DownloadFileFromUrl(string url)
        {
            return string.Empty;
        }
    }
}
