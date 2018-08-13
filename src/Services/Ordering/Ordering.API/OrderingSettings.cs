namespace Microsoft.eShopOnContainers.Services.Ordering.API
{
    public class OrderingSettings
    {
        public bool UseCustomizationData { get; set; }
        public string ConnectionString { get; set; }
        public string QFConnectionString { get; set; }

        public string EventBusConnection { get; set; }
        public string QFEventBusConnection { get; set; }

        public int CheckUpdateTime { get; set; }

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
