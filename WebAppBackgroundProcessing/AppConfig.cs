namespace WebAppBackgroundProcessing
{
    using System.Collections.ObjectModel;

    /// <summary>
    /// The app config.
    /// </summary>
    public class AppConfig
    {
        /// <summary>
        /// Gets or sets the application name.
        /// </summary>
        public string ApplicationName { get; set; }

        /// <summary>
        /// Gets or sets the services.
        /// </summary>
        public Collection<ServiceConfig> Services { get; set; }
    }
}
