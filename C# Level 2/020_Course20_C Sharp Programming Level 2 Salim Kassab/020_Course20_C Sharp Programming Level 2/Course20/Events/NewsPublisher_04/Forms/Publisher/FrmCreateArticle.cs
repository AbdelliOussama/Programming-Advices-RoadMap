using Course20.Events.NewsPublisher_04.Classes;
using Course20.Events.NewsPublisher_04.Forms;

namespace Course20.Events.NewsPublisher_04
{
    public partial class FrmCreateArticle : Form
    {
        public FrmCreateArticle() => InitializeComponent();

        /////////////////// Event ////////////////////
        public delegate void DataBackEventHandler(object sender, Article article);
        public event DataBackEventHandler dataBack;
        /////////////////////////////////////////////

        private void btnPublish_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtContent.Text))
            {
                MessageBox.Show("Please fill all form inputs!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Article article = new()
            {
                Id = FrmPublisherArticlesList.Articles.Count + 1,
                Title = txtTitle.Text,
                Content = txtContent.Text
            };

            dataBack.Invoke(this, article);

            FrmPublisherArticlesList.Articles.Add(article);
            MessageBox.Show("The Article has been published successfully");
            Close();
        }
    }
}