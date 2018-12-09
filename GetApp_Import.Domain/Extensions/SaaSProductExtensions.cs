namespace GetApp_Import.Domain.Extensions
{
    public static class SaaSProductExtensions
    {
        public static string GetCategoryName(this Category category)
        {
            switch (category)
            {
                case Category.BugsAndIssueTracking:
                    return "Bugs & Issue Tracking";
                case Category.DevelopmentTools:
                    return "Development Tools";
                case Category.InstantMessagingAndChat:
                    return "Instant Messaging & Chat";
                case Category.Productivity:
                    return "Productivity";
                case Category.WebCollaboration:
                    return "Web Collaboration";
                default:
                    return "Unknown Category";
            }
        }
    }
}
