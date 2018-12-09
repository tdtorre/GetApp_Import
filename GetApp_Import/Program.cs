using GetApp_Import.Services.ProviderService;
using System;

namespace GetApp_Import
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null)
            {
                Console.WriteLine("Params missing");
            }
            else
            {
                var source = args[0];
                var path = args[1];

                var provider = ProviderFactory.GetProvider(source);
                provider.Import(path);
            }

            Console.ReadLine();
        }
    }
}
