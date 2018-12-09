using System;
using System.Collections.Generic;
using System.Text;

namespace GetApp_Import.Services.Provider
{
    public static class ProviderFactory
    {
        private const string CapterraProvider = "capterra";
        private const string SoftwareAdviceProvider = "softwareadvice";

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
