using GetApp_Import.Domain;
using System.Collections.Generic;

namespace GetApp_Import.Data.DummyData
{
    public static class ProductsDummyData
    {
        public static List<SaaSProduct> GetCapterraProducts()
        {
            var capterraProducts = new List<SaaSProduct>();
            capterraProducts.Add(new SaaSProduct()
            {
                Id = 1,
                Name = "GitHub",
                Categories = new List<Category>() { Category.BugsAndIssueTracking, Category.DevelopmentTools },
                TwitterUser = "@github",
                Source = "capterra",
                SourceType = SourceType.YamlFile
            });

            capterraProducts.Add(new SaaSProduct()
            {
                Id = 2,
                Name = "Slack",
                Categories = new List<Category>() { Category.InstantMessagingAndChat, Category.WebCollaboration, Category.Productivity },
                TwitterUser = "@slackhq",
                Source = "capterra",
                SourceType = SourceType.YamlFile
            });

            return capterraProducts;
        }

        public static List<SaaSProduct> GetSoftwareAdvisorProducts()
        {
            var capterraProducts = new List<SaaSProduct>();
            capterraProducts.Add(new SaaSProduct()
            {
                Id = 3,
                Name = "Bitbucket",
                Categories = new List<Category>() { Category.BugsAndIssueTracking, Category.DevelopmentTools },
                TwitterUser = "@bitbucket",
                Source = "softwareadvisor",
                SourceType = SourceType.YamlFile
            });

            capterraProducts.Add(new SaaSProduct()
            {
                Id = 4,
                Name = "Microsoft Teams",
                Categories = new List<Category>() { Category.InstantMessagingAndChat, Category.WebCollaboration, Category.Productivity },
                TwitterUser = "@msteams",
                Source = "softwareadvisor",
                SourceType = SourceType.YamlFile
            });

            return capterraProducts;
        }
    }
}
