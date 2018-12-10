using GetApp_Import.Domain;
using GetApp_Import.Services.DataService.DataClients;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace GetApp_Import.Services.Test.DataService
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public async Task MySqlClientCreateTest()
        {
            // Arrange
            var saasProduct = new SaaSProduct()
            {
                Id = 2,
                Name = "TestProduct"
            };

            // Act
            var dataService = new MySqlClient();
            var result = await dataService.Create(saasProduct);

            // Assert
            Assert.Equals(result, true);
        }
    }
}
