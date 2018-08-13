namespace Microsoft.eShopOnContainers.Services.Basket.API
{
    public class BasketSettings
    {
        public string ConnectionString { get; set; }

        public string EventBusConnection { get; set; }
        public string QFEventBusConnection { get; set; }

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
