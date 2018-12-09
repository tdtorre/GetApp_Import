using System.Collections.Generic;
using GetApp_Import.Domain;

namespace GetApp_Import.Services.Provider
{
    public abstract class ProviderBase : IProviderBase
    {
        public ProviderBase()
        {
            this.Products = new List<SaaSProduct>();
            this.Source = SourceType.Unknown;
        }

        public SourceType Source { get; set; }

        public IList<SaaSProduct> Products { get;  protected set; }

        public void Import<T>(T source)
        {
            this.Products = this.Map(source);
            this.PersistData();
        }

        protected abstract IList<SaaSProduct> Map<T>(T source);

        protected abstract void PersistData();
    }
}
