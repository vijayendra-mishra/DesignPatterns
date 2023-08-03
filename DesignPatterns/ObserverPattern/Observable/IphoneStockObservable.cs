using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern.Observable
{
    public class IphoneStockObservable : IStockObservable
    {
        public List<INotificationAlertObserver> NotificationAlerts = new();

        public int totalStockCount = 0;

        public void Add(INotificationAlertObserver observer)
        {
            NotificationAlerts.Add(observer);
        }

        public void Remove(INotificationAlertObserver observer)
        {
            NotificationAlerts.Remove(observer);
        }

        public int GetStockCount()
        {
            return totalStockCount;
        }

        public void SetStockCount(int newStockAdded)
        {
            var itemWasOutOfStock = totalStockCount == 0;
            totalStockCount += newStockAdded;

            if (itemWasOutOfStock)
            {
                NotifyAll(); //back in stock
            }
        }

        public void NotifyAll()
        {
            foreach (INotificationAlertObserver observer in NotificationAlerts)
            {
                observer.Update();
            }
        }
    }
}
