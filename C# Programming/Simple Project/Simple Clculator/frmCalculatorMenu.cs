using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Clculator
{
    public partial class frmCalculatorMenu : Form
    {
        double Result = 0;
        string Operator = "";
        bool IsOpPerformed = false;
        public frmCalculatorMenu()
        {
            InitializeComponent();
        }
        public void ChangeToLightMood()
        {
            pContainer.BackColor = Color.Black;
            pKeys.BackColor = Color.AntiqueWhite;
            pScreen.BackColor = Color.White;
        }
       

        private void chkLightMood_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLightMood.Checked)
            {
                ChangeToLightMood();
            }
            else
            {
                pContainer.BackColor = Color.White;
                pKeys.BackColor = Color.DarkGray;
                pScreen.BackColor = Color.Black;
        
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblEquation.Text="";
            txtTotal.Text = "0";
            Result = 0;

        }

        private void On_Click(object sender, EventArgs e)
        {
            if ((txtTotal.Text == "0")||(IsOpPerformed))
                txtTotal.Clear();
            Button btnNumber = (Button )sender;
            IsOpPerformed = false;
            if(btnNumber.Text==".")
            {
                if(!txtTotal.Text.Contains("."))
                {
                    txtTotal.Text += btnNumber.Text;
                }
            }
            else
            {
                txtTotal.Text += btnNumber.Text;
            }
        }

        private void op_click(object sender, EventArgs e)
        {
            Button op = (Button)sender;
            if (Result != 0)
            {
                btnEqual.PerformClick();
                Operator = op.Text;
                lblEquation.Text = Result + "" + Operator;
                IsOpPerformed = true;
            }
            else
            {

                Operator = op.Text;
                Result = double.Parse(txtTotal.Text);
                txtTotal.Clear();
                IsOpPerformed = true;
                lblEquation.Text = Result + "" + Operator;
            }

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch(Operator)
            {
                case  "+":
                { 
                        txtTotal.Text = Convert.ToString(Result + Double.Parse(txtTotal.Text));
                        break;
                }
                case "-":
                {
                        txtTotal.Text = Convert.ToString(Result - Double.Parse(txtTotal.Text));
                        break;
                }
                case "*":
                {
                        txtTotal.Text = Convert.ToString(Result * Double.Parse(txtTotal.Text));
                        break;
                }
                case "/":
                {
                        txtTotal.Text = Convert.ToString(Result / Double.Parse(txtTotal.Text));
                        break;
                }
                default:
                    break;

            }
            Result = double.Parse(txtTotal.Text);
            lblEquation.Text = "";
             
        }
    }
}
