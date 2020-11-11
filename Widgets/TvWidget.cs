using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObserverSample.News;

namespace ObserverSample.Widgets
{
    class TvWidget : IWidget, IObserver
    {
        private string _tv;

        public void Update(object sender, NewsEventArgs e)
        {
            _tv = e.Tv;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("TV: {0}", _tv);
        }

        public void RemoveFromSubject() {
          
        }
    }
}
