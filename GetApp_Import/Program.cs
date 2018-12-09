using GetApp_Import.Services.DataService;
using GetApp_Import.Services.DataService.DataClients;
using GetApp_Import.Services.ProviderService;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace GetApp_Import
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                Console.WriteLine("Parameters are missing.");
            }
            else
            {
                try
                {
                    var source = args[0];
                    var path = args[1];

                    // configure services
                    var serviceCollection = new ServiceCollection().AddTransient<IDataService, MySqlClient>();

                    // create a service provider from the service collection
                    var serviceProvider = serviceCollection.BuildServiceProvider();
                    
                    // resolve the dependency
                    var dataService = serviceProvider.GetService<IDataService>();

                    // get proper provider and execute product import
                    var provider = ProviderFactory.GetProvider(source);
                    provider.Import(path, dataService);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            Console.ReadLine();
        }
    }
}
