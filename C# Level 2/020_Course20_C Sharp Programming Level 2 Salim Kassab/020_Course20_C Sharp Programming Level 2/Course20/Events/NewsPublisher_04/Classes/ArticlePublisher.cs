namespace Course20.Events.NewsPublisher_04.Classes
{
    public class ArticlePublisher
    {
        //////////////////// Event ///////////////////
        public event EventHandler<Article> newArticlePublished;
        protected virtual void onNewArticlePublished(Article article) => newArticlePublished?.Invoke(this, article);
        public void publishNewArticle(Article article) => onNewArticlePublished(article);

        //////////////////////////////////////////////
    }
}
