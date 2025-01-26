using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool_Table_My_Version
{
    public partial class ctrlPoolTable : UserControl
    {

        public class PoolTabelEventArgs : EventArgs
        {
            public string TimeText { get; }
            public string TimeInSecond { get; }
            public float HourRate { get; }
            public float TotalFees { get; }

            public PoolTabelEventArgs(string TimeString, string TimeSecond, float HourRate, float TotalFees)
            {
                this.TimeText = TimeString;
                this.TimeInSecond = TimeSecond;
                this.HourRate = HourRate;
                this.TotalFees = TotalFees;
            }
        }

        public event EventHandler<PoolTabelEventArgs> OnPoolTabelComplete;

        public void RaiseOnPoolTableComplete(string TimeText,string TimeInSecond,float HourRate,float TotalFees)
        {
            RaiseOnPoolTableComplete(new PoolTabelEventArgs(TimeText, TimeInSecond, HourRate, TotalFees));
        }
        protected virtual void RaiseOnPoolTableComplete(PoolTabelEventArgs e)
        {
            OnPoolTabelComplete?.Invoke(this, e);
        }

        private int _Second;

        private string _TableName;
        [
            Category("Pool Table Config"),
            Description("Table Name")
        ]

        public string TableName
        {
            get { return _TableName; }
            set
            {
                _TableName = value;
                gbTableName.Text = value;
                Invalidate();
            }   
        }

        private string _PlayerName;
        [
            Category("Pool Table Config"),
            Description("Player Name")
        ]
        public string PlayerName
        {
            get { return _PlayerName; }
            set
            {
                _PlayerName = value;
                
                Invalidate();
            }
        }

        private float _HourRate;
        [Category("Pool Table Config"),
         Description("Fees Per Hour")
        ]
        public float HourRate
        {
            get { return _HourRate; }
            set
            {
                _HourRate = value;
            }
        }
        public ctrlPoolTable()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            frmInputData frm = new frmInputData();
            frm.DataBack += _FillData;
            frm.ShowDialog();
            if(btnStart.Text =="Start")
            {
                btnStart.Text = "Stop";
                timer1.Start();
            }
            else
            {
                btnStart.Text = "Start";
                timer1.Stop();
            }

        }
        private void _FillData(object  sender,string PlayerName,float HourRate)
        {
            _PlayerName=PlayerName;
            lblPlayerName.Text = _PlayerName;
            _HourRate=HourRate;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _Second++;
            TimeSpan time = TimeSpan.FromSeconds(_Second);
            lblTimer.Text = time.ToString(@"hh\:mm\:ss");
            lblTimer.Refresh();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            float TotalFees = ((float)_Second / 60 / 60) * _HourRate;
            RaiseOnPoolTableComplete(lblTimer.Text, _Second.ToString(), _HourRate, TotalFees);
            _TableName = "Table";
            _PlayerName = "Player";
            lblTimer.Text = "00:00:00";
            btnStart.Text = "Start";

        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            lblPlayerName.Text = toolStripTextBox1.Text;
        }
    }
}
