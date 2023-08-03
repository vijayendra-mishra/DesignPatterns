
using DesignPatterns.ObserverPattern;
using DesignPatterns.ObserverPattern.Observable;

namespace Driver.Patterns
{
    public class ObserverRunner : IPatternRunner
    {
        public void Run()
        {
            IStockObservable iphoneStockObservable = new IphoneStockObservable();

            INotificationAlertObserver observer1 = new EmailAlertObserver(iphoneStockObservable, "abc@gmail.com");
            INotificationAlertObserver observer2 = new EmailAlertObserver(iphoneStockObservable, "xyz@gmail.com");
            INotificationAlertObserver observer3 = new MobileAlertObserver(iphoneStockObservable, "123456789");
            INotificationAlertObserver observer4 = new MobileAlertObserver(iphoneStockObservable, "987654321");

            iphoneStockObservable.Add(observer1);
            iphoneStockObservable.Add(observer2);
            iphoneStockObservable.Add(observer3);
            iphoneStockObservable.Add(observer4);

            iphoneStockObservable.SetStockCount(10);
        }
    }
}
