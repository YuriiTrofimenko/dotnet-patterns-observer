using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObserverSample.News;

namespace ObserverSample.Widgets
{
    /* Интерфейс наблюдателя */
    public interface IObserver
    {
        // Подписка с получением текстовой информации
        // string twitter, string lenta, string tv
        void Update(object sender, NewsEventArgs e);
        // Отписка от обработки событий
        void RemoveFromSubject();
    }
}