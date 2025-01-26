using Course20.Events.NewsPublisher_04.Classes;
using System.Data;

namespace Course20.Events.NewsPublisher_04.Forms.Subscribers
{
    public partial class FrmSubscriber : Form
    {
        public FrmSubscriber(int subscriberNumber)
        {
            InitializeComponent();
            setArticlesTableColumns();
            lblSubscriberNumber.Text = subscriberNumber.ToString();
        }

        //////////////////// Event ///////////////////
        public void subscribe(ArticlePublisher articlePublisher) => articlePublisher.newArticlePublished += handleNewArticle;
        public void unSubscribe(ArticlePublisher articlePublisher) => articlePublisher.newArticlePublished -= handleNewArticle;
        public void handleNewArticle(object sender, Article article)
        {
            DataRow dr = _articlesTable.NewRow();
            dr["Id"] = article.Id;
            dr["Title"] = article.Title;
            dr["Content"] = article.Content;

            _articlesTable.Rows.Add(dr);

            dgvSubscribedArticles.DataSource = _articlesTable;
            lblRecords.Text = dgvSubscribedArticles.Rows.Count.ToString();
        }
        //////////////////////////////////////////////

        private DataTable _articlesTable = new();

        private void setArticlesTableColumns()
        {
            _articlesTable.Columns.Add("Id".ToString());
            _articlesTable.Columns.Add("Title".ToString());
            _articlesTable.Columns.Add("Content".ToString());
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            subscribe(Form1.articlesPublisher);
            MessageBox.Show("Subscribed Successfully");
        }

        private void btnUnsubscribe_Click(object sender, EventArgs e)
        {
            unSubscribe(Form1.articlesPublisher);
            MessageBox.Show("Subscribed Canceled");
        }
    }
}