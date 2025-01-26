using Course20.Events.NewsPublisher_04.Classes;
using Course20.Events.NewsPublisher_04.Forms;

namespace Course20.Events.NewsPublisher_04
{
    public partial class FrmArticlesPublisherHome : Form
    {
        public FrmArticlesPublisherHome() => InitializeComponent();
        private Article _article = new();

        private void fillArticle(object sender, Article article)
        {
            _article.Id = article.Id;
            _article.Title = article.Title;
            _article.Content = article.Content;
        }
        private void btnPublish_Click(object sender, EventArgs e)
        {
            FrmCreateArticle frmCreateArticle = new();
            frmCreateArticle.dataBack += fillArticle;
            frmCreateArticle.ShowDialog();

            Form1.articlesPublisher.publishNewArticle(_article);
        }

        private void btnShowArticles_Click(object sender, EventArgs e)
        {
            FrmPublisherArticlesList frm = new();
            frm.ShowDialog();
        }
    }
}
