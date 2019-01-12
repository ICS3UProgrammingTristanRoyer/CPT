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
	public partial class Instructions : Form
	{
		public Instructions()
		{
			InitializeComponent();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Form1 theForm = new Form1();
			this.Hide();
			theForm.ShowDialog();
			this.Close();
		}
	}
}
