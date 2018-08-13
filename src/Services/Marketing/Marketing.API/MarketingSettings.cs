namespace Microsoft.eShopOnContainers.Services.Marketing.API
{
    public class MarketingSettings
    {
        public string ConnectionString { get; set; }
        public string QFConnectionString { get; set; }
        public string MongoConnectionString { get; set; }
        public string QFMongoConnectionString { get; set; }
        public string EventBusConnection { get; set; }
        public string QFEventBusConnection { get; set; }
        public string MongoDatabase { get; set; }
        public string ExternalCatalogBaseUrl { get; set; }
        public string CampaignDetailFunctionUri { get; set; }
        public string PicBaseUrl { get; set; }
        public bool AzureStorageEnabled { get; set; }

        public string GetConnectionString()
        {
#if QFDEBUG
            return QFConnectionString;
#else
            return ConnectionString;
#endif
        }
        public string GetMongoConnectionString()
        {
#if QFDEBUG
            return QFMongoConnectionString;
#else
            return MongoConnectionString;
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
