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

        public string ImportSource { get; set; }

        public DateTime ImportDate{ get; set; }

        public override string ToString()
        {
            // importing: Name: "Slack"; Categories: Instant Messaging & Chat, Web Collaboration, Productivity; Twitter: @slackhq

            var categories = this.Categories.ForEach(c => c.GetCategoryName());

            IList<string> strings = new List<string> { "1", "2", "testing" };
            string joined = string.Join(",", strings);

            return "Name: '{this.Name}'; " +
                   "Categories: '{}'; " +
                   "Twitter: '{this.TwitterUser}'";
        }
    }
}
