using System;
using GetApp_Import.Domain;

namespace GetApp_Import.Services.DataService.DataClients
{
    public class MongoDBClient : DataService
    {
        public MongoDBClient()
        {
            this.DataClientName = "MongoDB";
        }
        public override void Create(SaaSProduct product)
        {
            throw new NotImplementedException();
        }
    }
}
