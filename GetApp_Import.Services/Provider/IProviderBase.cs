using GetApp_Import.Domain;
using System;
using System.Collections.Generic;

namespace GetApp_Import.Services.Provider
{
    public interface IProviderBase
    {
        SourceType Source { get; set; }

        IList<SaaSProduct> Products { get; }

        void Import<T>(T source);
    }
}
