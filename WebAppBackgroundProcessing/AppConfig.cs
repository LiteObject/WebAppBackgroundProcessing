namespace WebAppBackgroundProcessing
{
    using System.Collections.ObjectModel;

    public class AppConfig
    {
        public string ApplicationName { get; set; }

        public Collection<ServiceConfig> Services { get; set; }
    }
}
