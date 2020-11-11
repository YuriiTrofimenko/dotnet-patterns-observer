using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverSample.News
{
    // Observable Interface (Интерфейс наблюдаемого объекта, издатель событий)
    public interface ISubject
    {
        // Добавить наблюдателя (потребитель)
        void RegisterObserver(Widgets.IObserver observer);
        // Удалить наблюдателя из списка
        void RemoveObserver(Widgets.IObserver observer);
        // Метод генерации события
        void NotifyObservers();
    }
}
