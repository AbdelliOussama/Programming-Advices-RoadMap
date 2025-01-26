using Course20.Events.NewsPublisher_04.Classes;

namespace Course20.Events.NewsPublisher_04.Forms
{
    public partial class FrmPublisherArticlesList : Form
    {
        public static List<Article> Articles = [];
        private void setDgvHeadersWidth()
        {
            dgvArticles.Columns[0].Width = 30;
            dgvArticles.Columns[1].Width = 100;
            dgvArticles.Columns[2].Width = 220;
        }

        public FrmPublisherArticlesList()
        {
            InitializeComponent();

            dgvArticles.DataSource = Articles;
            setDgvHeadersWidth();
            lblRecords.Text = Articles.Count.ToString();
        }
    }
}
