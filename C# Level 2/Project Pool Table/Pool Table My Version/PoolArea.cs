using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool_Table_My_Version
{
    public partial class frmPoolArea : Form
    {
        public frmPoolArea()
        {
            InitializeComponent();
        }

        private void ctrlPoolTable_OnPoolTabelComplete(object sender, ctrlPoolTable.PoolTabelEventArgs e)
        {
            MessageBox.Show($"Time Passed :{e.TimeText} ,Hour Rate:{e.HourRate}, Fees To Pay :{e.TotalFees} \a");
        }

     
    }
}
