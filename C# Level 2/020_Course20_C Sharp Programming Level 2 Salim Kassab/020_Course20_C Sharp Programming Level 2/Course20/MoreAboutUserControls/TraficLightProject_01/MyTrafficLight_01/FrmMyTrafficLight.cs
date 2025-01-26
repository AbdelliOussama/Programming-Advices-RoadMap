using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course20.MoreAboutUserControls.TraficLightProject_01.MyTrafficLight_01
{
	public partial class FrmMyTrafficLight : Form
	{
		public FrmMyTrafficLight()
		{
			InitializeComponent();
		}

		private void ctrlMyTrafficLight2_onRedCompleted(string obj) => MessageBox.Show(obj);

		private void ctrlMyTrafficLight2_onOrangeCompleted(string obj) => MessageBox.Show(obj);

		private void ctrlMyTrafficLight2_onGreenCompleted(string obj) => MessageBox.Show(obj);
	}
}
