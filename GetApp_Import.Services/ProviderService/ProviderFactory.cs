using GetApp_Import.Services.ProviderService.Providers;
using System;

namespace GetApp_Import.Services.ProviderService
{
    public static class ProviderFactory
    {
        private const string CapterraProvider = "capterra";
        private const string SoftwareAdviceProvider = "softwareadvice";
        private const string CsvFileProvider = "csvfile";

        /// <summary>
        /// Get the proper Product Provider based on the type
        /// </summary>
        /// <param name="providerType">Product Provider</param>
        /// <returns></returns>
        public static IProviderBase GetProvider(string providerType)
        {
            switch (providerType.ToLower())
            {
                case CapterraProvider:
                    return new CapterraProvider();
                case SoftwareAdviceProvider:
                    return new SoftwareAdviceProvider();
                case CsvFileProvider:
                    return new CsvFileProvider();
                default:
                    throw new Exception("Provider not implemented");
            }
        }
    }
}
