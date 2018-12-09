using GetApp_Import.Data.DummyData;
using GetApp_Import.Domain;
using GetApp_Import.Services.DataService.DataClients;
using GetApp_Import.Services.ProviderService.Providers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace GetApp_Import.Services.Test.ProviderService
{
    [TestClass]
    public class ProviderBaseTest
    {
        [TestMethod]
        public void ImportTest()
        {
            // Arrange
            var dataService = new Mock<IMySqlClient>();
            var capterraProvider = new CapterraProvider();
            var path = "feed-products/capterra.yaml";
            var expectedProducts = ProductsDummyData.GetCapterraProducts();

            // Act
            capterraProvider.Import(path, dataService.Object);

            // Assert
            Assert.IsNotNull(capterraProvider.Products);
            CollectionAssert.AreEquivalent(expectedProducts, (capterraProvider.Products as List<SaaSProduct>));
            Assert.AreEqual(expectedProducts.Count, capterraProvider.Products.Count);
        }
    }
}
