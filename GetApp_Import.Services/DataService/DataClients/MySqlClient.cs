using System;
using GetApp_Import.Domain;

namespace GetApp_Import.Services.DataService.DataClients
{
    public class MySqlClient : DataService
    {
        public MySqlClient()
        {
            this.DataClientName = "MySQL";
        }

        public override void Create(SaaSProduct product)
        {
            var importerdProduct = product;
        }
    }
}
