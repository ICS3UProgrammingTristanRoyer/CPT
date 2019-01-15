using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CptSideScrollerTristanR
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			prbProgressBar.Value += 10;
			if (prbProgressBar.Value == 100)
			timer.Stop();
			/*//if (lblLoading.Text == "Loading.")
			//{
			//	lblLoading.Text = ("Loading..");
			//}
			//if (lblLoading.Text == "Loading..")
			//{
				lblLoading.Text = ("Loading...");

			}
			if (lblLoading.Text == "Loading...")
			{
				lblLoading.Text = ("Loading.");
			}*/
		}
	}
}
