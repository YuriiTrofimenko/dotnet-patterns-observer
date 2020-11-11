using System;
using ObserverSample.News;
using ObserverSample.Widgets;

namespace observer
{
    class Program
    {
        static void Main(string[] args)
        {
          // создание одного издателя событий
            var newsAggregator = new NewsAggregator();
            // создание трех наблюдателей
            var twitterWidget = new TwitterWidget();
            var lentaWidget = new LentaWidget();
            var tvWidget = new TvWidget();
            // подписка наблюдателей на событие NewsChanged издателя
            //System.Console.WriteLine(newsAggregator.NewsChanged);
            newsAggregator.NewsChanged += twitterWidget.Update;
            //System.Console.WriteLine(newsAggregator.NewsChanged);
            newsAggregator.NewsChanged += lentaWidget.Update;
            //System.Console.WriteLine(newsAggregator.NewsChanged);
            newsAggregator.NewsChanged += tvWidget.Update;
            //System.Console.WriteLine(newsAggregator.NewsChanged);

            newsAggregator.NewNewsAvailable();
            Console.WriteLine();

            newsAggregator.NewsChanged -= twitterWidget.Update;
            newsAggregator.NewNewsAvailable();
            Console.WriteLine();
            newsAggregator.NewNewsAvailable();

            Console.ReadLine();
        }
    }
}
