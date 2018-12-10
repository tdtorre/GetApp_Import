using System;
using System.Threading.Tasks;
using GetApp_Import.Data;
using GetApp_Import.Domain;

namespace GetApp_Import.Services.DataService.DataClients
{
    public class MongoDBClient : DataService, IMongoDBClient
    {
        public MongoDBClient()
        {
            this.DataClientName = "MongoDB";
        }

        /// <inheritdoc/>
        public override async Task<bool> Create(SaaSProduct product)
        {
            using (var mongoDbDataContext = new MongoDbDataContext())
            {
                // Do things...
            }

            throw new NotImplementedException();

            return false;
        }
    }
}
