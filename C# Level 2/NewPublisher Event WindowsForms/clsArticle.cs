using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPublisher_Event_WindowsForms
{
    public  class clsArticle
    {
       public  string Content { get; set; }
        public string Title { get; set; }
        public string PublisherName {  get; set; }

        public clsArticle(string Content,string Title,string PublisherName)
        {
            this.Content = Content;
            this.Title = Title;
            this.PublisherName = PublisherName;
        }

    }
}
