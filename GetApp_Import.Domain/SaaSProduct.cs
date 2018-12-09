using System;
using System.Collections.Generic;
using System.Linq;
using GetApp_Import.Domain.Extensions;

namespace GetApp_Import.Domain
{
    public class SaaSProduct
    {
        public SaaSProduct()
        {
            this.Categories = new List<Category>();
            this.ImportDate = DateTime.Now;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public IList<Category> Categories { get; set; }

        public string TwitterUser { get; set; }

        public string Source { get; set; }

        public SourceType SourceType { get; set; }

        public DateTime ImportDate{ get; set; }

        public override string ToString()
        {
            var categories = this.Categories.Select(c => c.GetCategoryName());
            string concatCategories = string.Join(", ", categories);

            return $"Name: {this.Name}; " +
                   $"Categories: {concatCategories}; " +
                   $"Twitter: {this.TwitterUser}";
        }
    }
}
