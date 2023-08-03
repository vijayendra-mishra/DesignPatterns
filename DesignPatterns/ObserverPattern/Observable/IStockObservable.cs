namespace DesignPatterns.ObserverPattern
{
    public interface IStockObservable
    {
        void Add(INotificationAlertObserver observer);
        void Remove(INotificationAlertObserver observer);
        void NotifyAll();
        void SetStockCount(int newStockAdded);
        int GetStockCount();

    }
}
