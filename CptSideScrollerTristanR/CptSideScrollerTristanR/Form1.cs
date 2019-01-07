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
			Thread load = new Thread(new ThreadStart(StartSplash));
			load.Start();
			Thread.Sleep(2000);
			InitializeComponent();
			load.Abort();
		}
		public void StartSplash()

		{
			Application.Run(new Form2());
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			Form3 theForm = new Form3();
			this.Hide();
			theForm.ShowDialog();
			this.Close();
		}
	}
}
