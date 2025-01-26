using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblResult.Text = (int.Parse(txtNum1.Text)+int.Parse(txtNum2.Text)).ToString();
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some Required  Fields Are Not Valid Put The Mouse In the red Icon To See The Error","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
          
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNum1_Validating(object sender, CancelEventArgs e)
        {
            if(txtNum1.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtNum1, "This Feild Is Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtNum1,null);
                e.Cancel= false;
            }
        }
    
        private void txtNum2_Validating_1(object sender, CancelEventArgs e)
        {
            if (txtNum2.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtNum2, "This Feild Is Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtNum2, null);
                e.Cancel = false;
            }
        }
    }
}
