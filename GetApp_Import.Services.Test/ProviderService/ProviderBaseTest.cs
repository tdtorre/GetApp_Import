using GetApp_Import.Data.DummyData;
using GetApp_Import.Domain;
using GetApp_Import.Services.DataService.DataClients;
using GetApp_Import.Services.ProviderService.Providers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetApp_Import.Services.Test.ProviderService
{
    [TestClass]
    public class ProviderBaseTest
    {
        [TestMethod]
        public async Task CapterraImportTest()
        {
            // Arrange
            var dataService = new Mock<IMySqlClient>();
            var capterraProvider = new CapterraProvider();
            var path = "feed-products/capterra.yaml";
            var expectedProducts = ProductsDummyData.GetCapterraProducts();

            // Act
            await capterraProvider.Import(path, dataService.Object);
            var products = capterraProvider.Products;

            // Assert
            Assert.IsNotNull(capterraProvider.Products);
            Assert.AreEqual(expectedProducts.Count, capterraProvider.Products.Count);
        }

        [TestMethod]
        public async Task SoftwareAdviseImportTest()
        {
            // Arrange
            var dataService = new Mock<IMySqlClient>();
            var softwareAdviseProvider = new SoftwareAdviceProvider();
            var path = "feed-products/capterra.yaml";
            var expectedProducts = ProductsDummyData.GetCapterraProducts();

            // Act
            await softwareAdviseProvider.Import(path, dataService.Object);

            // Assert
            Assert.IsNotNull(softwareAdviseProvider.Products);
            Assert.AreEqual(expectedProducts.Count, softwareAdviseProvider.Products.Count);
        }
    }
}
