namespace Microsoft.eShopOnContainers.Services.Identity.API
{
    public class AppSettings
    {
        public string ConnectionString { get; set; }
        public string QFConnectionString { get; set; }

        public string MvcClient { get; set; }

        public bool UseCustomizationData { get; set; }

        public string GetConnectionString()
        {
#if QFDEBUG
            return QFConnectionString;
#else
            return ConnectionString;
#endif
        }
    }
}
