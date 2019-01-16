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
		// function that changes the "loading" label to give it a ... effect
		private void Loading()
		{
			if (lblLoading.Text == "Loading.")
			{
				lblLoading.Text = "Loading..";
			}
			else if (lblLoading.Text == "Loading..")
			{
				lblLoading.Text = "Loading...";
			}
			else if (lblLoading.Text == "Loading...")
			{
				lblLoading.Text = "Loading.";
			}

		}

		private void timer_Tick(object sender, EventArgs e)
		{
			// for every tick on the timer the progress bar is incremented by ten and the "loading" label is altered
			prbProgressBar.Value += 10;
			Loading();

			// if the progress bar reaches a value of 100 the splash screen is closed and the menu is shown.
			if (prbProgressBar.Value == 100)
			timer.Stop();

			
			
		}
	}
}
