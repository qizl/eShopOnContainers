namespace Microsoft.eShopOnContainers.Services.Locations.API
{
    public class LocationSettings
    {
        public string ExternalCatalogBaseUrl { get; set; }
        public string EventBusConnection { get; set; }
        public string QFEventBusConnection { get; set; }
        public string ConnectionString { get; set; }
        public string QFConnectionString { get; set; }
        public string Database { get; set; }

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
