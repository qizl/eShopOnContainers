namespace Microsoft.eShopOnContainers.Services.Catalog.API
{
    public class CatalogSettings
    {
        public string PicBaseUrl { get; set; }

        public string ConnectionString { get; set; }
        public string QFConnectionString { get; set; }

        public string EventBusConnection { get; set; }
        public string QFEventBusConnection { get; set; }

        public bool UseCustomizationData { get; set; }
        public bool AzureStorageEnabled { get; set; }

        public string GetConnectionString()
        {
#if QFDEBUG
            return QFConnectionString;
#else
            return ConnectionString;
#endif
        }
        public string GetEventBusConnection()
        {
#if QFDEBUG
            return QFEventBusConnection;
#else
            return EventBusConnection;
#endif
        }
    }
}
