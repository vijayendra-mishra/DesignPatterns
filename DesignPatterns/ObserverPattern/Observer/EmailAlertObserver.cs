namespace DesignPatterns.ObserverPattern
{
    public class EmailAlertObserver : INotificationAlertObserver
    {
        private readonly IStockObservable stockObservable;
        private readonly string emailId;

        public EmailAlertObserver(IStockObservable stockObservable, string emailId)
        {
            this.stockObservable = stockObservable;
            this.emailId = emailId;
        }

        public void Update()
        {
            SendEmail(emailId, $"Product back in stock, stock count: {stockObservable.GetStockCount()}");
        }

        private void SendEmail(string emailId, string msg)
        {
            Console.WriteLine($"{msg} sent to: {emailId}");
        }
    }
}