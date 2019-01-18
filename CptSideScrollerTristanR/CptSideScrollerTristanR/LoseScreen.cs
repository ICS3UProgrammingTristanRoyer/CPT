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
	public partial class LoseScreen : Form
	{
		public LoseScreen()
		{
			InitializeComponent();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			// hides this from and shows the menu again.
			Form1 theForm = new Form1();
			this.Hide();
			theForm.ShowDialog();
			this.Close();
		}
	}
}
