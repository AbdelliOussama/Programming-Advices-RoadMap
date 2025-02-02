using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginUi
{
    public partial class frmLogin : Form
    {
        UserControl Registration;
        public frmLogin()
        {
            InitializeComponent();
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "oussama" && txtPassword.Text == "oussama")
            {
                Registration Register = new Registration();
                AddUserControl(Register);

            }
            else
                MessageBox.Show("Invalide UserName Or Password", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
                txtPassword.PasswordChar = '*';
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
