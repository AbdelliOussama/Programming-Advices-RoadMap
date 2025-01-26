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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.NewNewsArticle += DispalyNotification;
            frm.ShowDialog();

        }
        private void DispalyNotification(object sender, clsArticle article)
        {
            label1.Visible = true;
            label1.Text = "New Article Published By " + article.PublisherName + " About " + article.Title;
        }
    }
}
