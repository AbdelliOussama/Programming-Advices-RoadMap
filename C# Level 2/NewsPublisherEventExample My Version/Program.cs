using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPublisherEventExample_My_Version
{
    internal class Program
    {
        public class NewsArticle
        {
            public string Title { get; }
            public string Content { get; }

            public NewsArticle(string title, string content)
            {
                this.Title = title;
                this.Content = content;
            }
        }

        public class NewsPublisher
        {
            public event EventHandler<NewsArticle> NewNewsArticle;

            public void PublishNewArticle(string Title, string Content)
            {
                NewsArticle NewsArticle = new NewsArticle(Title, Content);
                OnNewsArticlePublished(NewsArticle);
            }

            protected virtual void OnNewsArticlePublished(NewsArticle article)
            {
                NewNewsArticle?.Invoke(this, article);
            }
        }

        public class NewsSubscriber
        {
            public string Name { get; }
            public NewsSubscriber(string name)
            {
                this.Name = name;
            }

            public void SubscribeToNews(NewsPublisher publisher)
            {
                publisher.NewNewsArticle += HandelNewNews;
            }
            public void UnSubscribe(NewsPublisher publisher)
            {
                publisher.NewNewsArticle -= HandelNewNews;
            }

            public void HandelNewNews(object sender, NewsArticle article)
            {
                Console.WriteLine($"{Name} Has Subscribed On The News");
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Content);
            }

            static void Main(string[] args)
            {
                NewsPublisher publisher1 = new NewsPublisher();
                NewsSubscriber Subscriber1 = new NewsSubscriber("Oussama");


                Subscriber1.SubscribeToNews(publisher1);

                publisher1.PublishNewArticle("Boxing Championship Planning", "The Tunisian Boxing Federation Has Uploaded the Finale Planning Of The Regional Championship ");


                Console.ReadLine();
            }
        }
    }
}
