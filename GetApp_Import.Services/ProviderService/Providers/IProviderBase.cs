using GetApp_Import.Domain;
using System;
using System.Collections.Generic;
using System.IO;

namespace GetApp_Import.Services.ProviderService.Providers
{
    public interface IProviderBase
    {
        SourceType Source { get; set; }

        IList<SaaSProduct> Products { get; }

        void Import(string source);
    }
}
