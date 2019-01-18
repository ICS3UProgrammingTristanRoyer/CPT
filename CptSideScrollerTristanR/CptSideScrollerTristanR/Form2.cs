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

	public partial class Form2 : Form
	{
		const int MAX_STRINGS = 10;
		// create an array to store the tip strings
		List<String> listTips = new List<String>();
		int aRandomNumber;
		Random rng = new Random();
		public Form2()
		{
			// inserts the tips to the list
			listTips.Insert(0, "There is a strange presence here...");
			listTips.Insert(1, "coins are shiny why not collect them?:)");
			listTips.Insert(2, "Doors usually require keys to unlock...");
			listTips.Insert(3, "platforms allow you to stay above the flames!");
			listTips.Insert(4, "blue coloured portals are dangerous...");
			listTips.Insert(5, "upon reaching level 2 you are assigned 3 lives.");
			listTips.Insert(6, "Those who enter red portals never return...");
			listTips.Insert(7, "The beast sleeps...");
			listTips.Insert(8, "There is rumored to be a blade that can slay monsters...");
			listTips.Insert(9, "Defeat the monster to reach the light...");
			listTips.Insert(10, "avoid the flames...");

			InitializeComponent();

		}
		 //function that changes the "loading" label to give it a ... effect
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

				else  
				{
					lblLoading.Text = "Loading.";
				}


		}

		private void timer_Tick(object sender, EventArgs e)
		{
			// adds value to the progress bar and calls the loading function
				prbProgressBar.Value += 10;
				Loading();
			

			if (prbProgressBar.Value == 100)
			{
				// if the progress bar reaches a value of 100 the splash screen is closed and the menu is shown.
				timer.Stop();
				
			}
			
			}

		private void tipTimer_Tick(object sender, EventArgs e)
		{
			// generates a random number which determines the tip that is shown
		
			aRandomNumber = rng.Next(0, 10);
			lblTips.Text = listTips[aRandomNumber];
		}

	}
}
