using GetApp_Import.Data.DummyData;
using GetApp_Import.Domain;
using GetApp_Import.Services.DataService.DataClients;
using GetApp_Import.Services.ProviderService.Providers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace GetApp_Import.Services.Test.DataService
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void MySqlClientCreateTest()
        {
            // Arrange
            var saasProduct = new SaaSProduct()
            {
                Id = 2,
                Name = "TestProduct"
            };

            // Act
            var dataService = new MySqlClient();
            dataService.Create(saasProduct);

            // Assert
            
        }
    }
}
