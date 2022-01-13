using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    enum Category
    {
        News = 1,
        Weather,
        Sport,
        Events,
        Humor
    }
    internal class NewsOperator
    {
        private delegate void MethodAddTo(string msg);
        private event MethodAddTo SubscribeNews;
        private event MethodAddTo SubscribeWeather;
        private event MethodAddTo SubscribeSport;
        private event MethodAddTo SubscribeEvents;
        private event MethodAddTo SubscribeHumor;
        public void SubscribeTo(Category id, Subscriber item)
        {
            switch (id)
            {
                case Category.News:
                    SubscribeNews += item.AddNews;
                    break;
                case Category.Weather:
                    SubscribeWeather += item.AddNews;
                    break;
                case Category.Sport:
                    SubscribeSport += item.AddNews;
                    break;
                case Category.Events:
                    SubscribeEvents += item.AddNews;
                    break;
                case Category.Humor:
                    SubscribeHumor += item.AddNews;
                    break;
                default:
                    break;
            }
        }

        public void SubscribeFrom(Category id, Subscriber item)
        {
            switch (id)
            {
                case Category.News:
                    SubscribeNews -= item.AddNews;
                    break;
                case Category.Weather:
                    SubscribeWeather -= item.AddNews;
                    break;
                case Category.Sport:
                    SubscribeSport -= item.AddNews;
                    break;
                case Category.Events:
                    SubscribeEvents -= item.AddNews;
                    break;
                case Category.Humor:
                    SubscribeHumor -= item.AddNews;
                    break;
                default:
                    break;
            }
        }

        public void AddNews(Category id, string msg)
        {
            switch (id)
            {
                case Category.News:
                    if (SubscribeNews != null)
                        SubscribeNews(msg);
                    break;
                case Category.Weather:
                    if (SubscribeWeather != null)
                        SubscribeWeather(msg);
                    break;
                case Category.Sport:
                    if (SubscribeSport != null)
                        SubscribeSport(msg);
                    break;
                case Category.Events:
                    if (SubscribeEvents != null)
                        SubscribeEvents(msg);
                    break;
                case Category.Humor:
                    if (SubscribeHumor != null)
                        SubscribeHumor(msg);
                    break;
                default:
                    break;
            }
        }
    }
}
