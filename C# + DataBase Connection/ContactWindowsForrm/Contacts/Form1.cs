using ContactBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class frmListContatcs : Form
    {
        public frmListContatcs()
        {
            InitializeComponent();
        }
        private void _RefreshListContatcs()
        {
            dgvAllContacts.DataSource = clsContacts.GetAllContacts();
        }
        private void frmListContatcs_Load(object sender, EventArgs e)
        {
            _RefreshListContatcs();

        }

        private void btnAddNewContact_Click(object sender, EventArgs e)
        {
            Form Form1 = new frmAddEditContact(-1);
            Form1.ShowDialog();
            _RefreshListContatcs();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditContact frm = new frmAddEditContact((int)dgvAllContacts.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshListContatcs();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure you want to delete Contact ID [" + dgvAllContacts.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsContacts.DeleteContact((int)dgvAllContacts.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Contact Deleted Succesfully");
                    _RefreshListContatcs();
                }
                else
                    MessageBox.Show("Failed To delete Contact");
            }
        }
    }
}
