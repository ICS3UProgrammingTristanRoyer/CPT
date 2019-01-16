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

namespace CptSideScrollerTristanR
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			// aborts the load to allow the splash screen to be shown first
			Thread load = new Thread(new ThreadStart(StartSplash));
			load.Start();
			Thread.Sleep(2000);
			InitializeComponent();
			load.Abort();
		}
		public void StartSplash()

		{
			// runs the splash screen before the menu appears
			Application.Run(new Form2());
		}

		

		private void btnStart_Click(object sender, EventArgs e)
		{
			Form3 theForm = new Form3();
			
			this.Hide();
			theForm.ShowDialog();
			this.Close();
		}

		private void btnInstuctions_Click(object sender, EventArgs e)
		{
			// opens the instructions form
			Instructions theForm = new Instructions();
			this.Hide();
			theForm.ShowDialog();
			this.Close();
		}

		private void btnTips_Click(object sender, EventArgs e)
		{
			// opens the Tips form
			TipScreen theForm = new TipScreen();
			this.Hide();
			theForm.ShowDialog();
			this.Close();

		}
	}
}
