using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course20.TraficLight_008
{
    public partial class FrmTrafficViolation : Form
    {
        private int _trafficViolations = 0;
        public FrmTrafficViolation(int trafficViolationsCount)
        {
            InitializeComponent();
            SoundPlayer soundPlayer = new("sound.wav");
            soundPlayer.Play();
            if (trafficViolationsCount >= 3)
                label1.Text = "Your driving license was detained due to exceeding \nthe maximum limit for traffic signal violations.\nPlease visit the Traffic Department to pay the fine \nand get your license back.";
            else
                label1.Text = $"Stop, Traffic violation number: {trafficViolationsCount}";
        }
    }
}