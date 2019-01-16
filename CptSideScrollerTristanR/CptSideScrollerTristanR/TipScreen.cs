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
	public partial class TipScreen : Form
	{
		public TipScreen()
		{
			InitializeComponent();
		}

		
		private void btnBack_Click(object sender, EventArgs e)
		{
			// goes to the main menu
			Form1 theForm = new Form1();
			this.Hide();
			theForm.ShowDialog();
			this.Close();
		}
	}
}
