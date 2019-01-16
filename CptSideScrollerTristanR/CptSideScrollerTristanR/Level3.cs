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
	public partial class Level3 : Form
	{
		bool goleft = false; // boolean which will control the character going left
		bool goright = false; // boolean which will control the character going right
		bool jumping = false; // boolean to check if the player is jumping or not
		int playSpeed = 8; // this int will set the character's speed to 18
		int playSpeed2 = -8; // this int will set the other character's speed to -18
		int jumpSpeed = 12; // int to set the jump speed
		int force = 8; // force of the jump in an integer
		// allows sounds to be played
		System.Media.SoundPlayer backSound = new System.Media.SoundPlayer();


		public Level3()
		{
			// assigns the file location to the background sound 
			backSound.SoundLocation = "night.wav";
			InitializeComponent();
			// plays the background music
			backSound.PlayLooping();
		}


		private void mainGameTimer(object sender, EventArgs e)
		{




			// if jumping is true and force is less than 0
			// then change jumping to false
			if (jumping && force < 0)
			{
				jumping = false;
			}
			// if jumping is true 
			// then change jump speed to -25
			// reduce force by 1
			if (jumping)
			{
				jumpSpeed = -25;

				force -= 1;
			}
			else
			{
				// else change the jump speed to 12
				jumpSpeed = 12;
			}

			// if go left is true and players left is greater than 100 pixels
			// only then move the character towards left of the
			if (goleft)//&& background.Left > 100
			{
				//background.Left -= playSpeed;
				player2.Left -= playSpeed2;
				player.Left -= playSpeed;

			}
			// by doing the if statement above, the player picture will stop

			// if go right Bool is true
			// player left plus players width plus 100 is less than the forms width
			// then we move the player towards the right by adding to the players left
			if (goright) //&& background.Left + (background.Width + 100) < this.ClientSize.Width
			{
				//background.Left += playSpeed;
				player2.Left += playSpeed2;
				player.Left += playSpeed;

			}
			// by doing the if statement above , the player picture will stop on the forms right



			// below if the for loop thats checking for all of the controls in this form
			foreach (Control x in this.Controls)
			{
				// is X is a picture box and it has a tag of a platform
				if (x is PictureBox && (String)x.Tag == "platform")
				{
					// then we are checking if the player is colliding with the platform
					// and jumping is set to false
					if (!jumping)
					{
						// then we do the following 
						// set the force to 8
						force = 8;


						player2.Top = x.Top - player2.Height; // also we place the player on top of the picture box
						player.Top = x.Top - player.Height; // also we place the player on top of the picture box

						jumpSpeed = 0; // set the jump speed to 0
					}
				}
				// is X is a picture box and it has a tag of a platform
				if (x is PictureBox && (String)x.Tag == "pillar")
				{   // now if the player collides with the pic box
					if (player.Bounds.IntersectsWith(x.Bounds))
					{
						// plays the background music
						backSound.Stop();
						// and stop the timer
						gameTimer.Stop();
						// displays the win screen
						WinScreen theForm = new WinScreen();
						this.Hide();
						theForm.ShowDialog();
						this.Close();
					}


				}










			}
		}

		private void keyisdown(object sender, KeyEventArgs e)
		{
			// if the player pressed the left key AND the player is inside the panel 
			// then we set the car left boolean to be true
			if (e.KeyCode == Keys.Left)
			{
				goleft = true;
			}

			// if player pressed the right key and the player left plus player width is less than the panell width

			if (e.KeyCode == Keys.Right)
			{
				// then we set the plater right to be true
				goright = true;
			}

			// if the player pressed the space key and jumping boolean is false

			if (e.KeyCode == Keys.Space && !jumping)
			{
				// then we set jumping to true
				jumping = true;
			}

		}

		private void keyisup(object sender, KeyEventArgs e)
		{
			// if the LEFT key is up we set the char left to false
			if (e.KeyCode == Keys.Left)
			{
				goleft = false;
			}
			// if the RIGHT key is up we set the car right to false
			{
				goright = false;
			}
			// when the keys are released we check if jumping is true
			// if so we need to set it back to false so the player can jump again
			if (jumping)
			{
				jumping = false;
			}

		}
	}
}
