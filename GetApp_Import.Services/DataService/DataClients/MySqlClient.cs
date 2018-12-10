using System;
using System.Threading.Tasks;
using GetApp_Import.Data;
using GetApp_Import.Domain;

namespace GetApp_Import.Services.DataService.DataClients
{
    public class MySqlClient : DataService, IMySqlClient
    {
        public MySqlClient()
        {
            this.DataClientName = "MySQL";
        }

        public override async Task<bool> Create(SaaSProduct product)
        {
            var importerdProduct = product;

            using(var mySqlDataContext = new MySqlDataContext())
            {
                // Do things...
            }

            // Adding this delay to simulate the database interaction
            await Task.Delay(2000);

            // We asume that the result is ok
            return true;
        }
    }
}
