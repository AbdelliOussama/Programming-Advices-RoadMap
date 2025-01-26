using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewPublisher_Event_WindowsForms
{
    public partial class Form1 : Form
    {
        private clsArticle _Article;

        public event EventHandler<clsArticle>NewNewsArticle;

        protected virtual void OnNewsPublished(clsArticle article)
        {
            NewNewsArticle?.Invoke(this,article);
        }
          
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            _Article = new clsArticle(txtArticleContent.Text,txtArticleTitle.Text,"Oussama");
            OnNewsPublished( _Article );
            this.Close();
        }
    }
}
