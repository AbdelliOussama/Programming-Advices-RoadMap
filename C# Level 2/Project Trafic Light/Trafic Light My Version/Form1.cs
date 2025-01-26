using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Trafic_Light_My_Version
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctrlTraficLight1.Start();
            ctrlTraficLight2.Start();
            ctrlTraficLight3.Start();
            ctrlTraficLight4.Start();

        }

        private void ctrlTraficLight1_GreenLightOn(object sender, ctrlTraficLight.TraficLightEventArgs e)
        {
            ctrlTraficLight2.CurrentLightColor = ctrlTraficLight.enTraficLightColor.red;
        }

        private void ctrlTraficLight1_RedLightOn(object sender, ctrlTraficLight.TraficLightEventArgs e)
        {
            ctrlTraficLight3.CurrentLightColor = ctrlTraficLight.enTraficLightColor.green;
            ctrlTraficLight4.CurrentLightColor = ctrlTraficLight.enTraficLightColor.green;

        }

        private void ctrlTraficLight1_YellowLightOn(object sender, ctrlTraficLight.TraficLightEventArgs e)
        {
            
        }
    }
}
