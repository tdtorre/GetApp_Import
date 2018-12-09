using System;
using System.Collections.Generic;
using GetApp_Import.Domain;

namespace GetApp_Import.Services.Provider
{
    public class CapterraProvider : ProviderBase, ICapterraProvider
    {
        public CapterraProvider()
            : base()
        {
            this.Source = SourceType.YamlFile;
        }

        protected override IList<SaaSProduct> Map<T>(T source)
        {
            throw new NotImplementedException();
        }

        protected override void PersistData()
        {
            throw new NotImplementedException();
        }
    }
}
