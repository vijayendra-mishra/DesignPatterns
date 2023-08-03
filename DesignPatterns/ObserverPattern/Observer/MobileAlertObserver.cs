namespace DesignPatterns.ObserverPattern
{
    public class MobileAlertObserver : INotificationAlertObserver
    {
        private readonly IStockObservable stockObservable;
        private readonly string phoneNo;

        public MobileAlertObserver(IStockObservable stockObservable, string phoneNo)
        {
            this.stockObservable = stockObservable;
            this.phoneNo = phoneNo;
        }

        public void Update()
        {
            SendMsg(phoneNo, $"Product back in stock, stock count: {stockObservable.GetStockCount()}");
        }

        private void SendMsg(string phoneNo, string msg)
        {
            Console.WriteLine($"{msg} sent to: {phoneNo}");
        }
    }
}