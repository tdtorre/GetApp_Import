using GetApp_Import.Services.ProviderService.Providers;
using System;

namespace GetApp_Import.Services.ProviderService
{
    public static class ProviderFactory
    {
        private const string CapterraProvider = "capterra";
        private const string SoftwareAdviceProvider = "softwareadvice";

        /// <summary>
        /// Get the proper provider based on the type
        /// </summary>
        /// <param name="providerType"></param>
        /// <returns></returns>
        public static IProviderBase GetProvider(string providerType)
        {
            switch (providerType.ToLower())
            {
                case CapterraProvider:
                    return new CapterraProvider();
                case SoftwareAdviceProvider:
                    return new CapterraProvider();
                default:
                    throw new Exception("Provider not implemented");
            }
        }
    }
}
