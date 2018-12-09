using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using GetApp_Import.Domain;

namespace GetApp_Import.Services.ProviderService.Providers
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

        public void Import(string source)
        {
            this.Products = this.Map(source);
            this.PersistData();
        }

        protected virtual StreamReader GetFileFromSource(string sourcePath)
        {
            //var reader = new StreamReader(sourcePath);
            var reader = StreamReader.Null;
            return reader;
        }

        protected void PersistData()
        {
            foreach(var product in this.Products)
            {
                Console.WriteLine("import " + product);
            }
        }

        protected abstract IList<SaaSProduct> Map(string source);
    }
}
