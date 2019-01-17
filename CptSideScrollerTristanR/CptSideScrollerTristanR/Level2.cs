using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using System.Windows.Media;
using WMPLib;

namespace CptSideScrollerTristanR
{
	public partial class Level2 : Form
	{
		bool goleft = false; // boolean which will control the character going left
		bool goright = false; // boolean which will control the character going right
		bool jumping = false; // boolean to check if the player is jumping or not
		bool hasSword = false; // boolean to determine if the player has obtained the key or not.

		int jumpSpeed = 12; // int to set the jump speed
		int force = 8; // force of the jump in an integer
		int score = 0; // default score int set to 0
		int lives = 3;


		int playSpeed = 18; // this int will set the character's speed to 18
		int backLeft = 8; // this integer will set the background moving speed to 8
		// uses system media sound player to be able to play music
		System.Media.SoundPlayer backSound = new System.Media.SoundPlayer();

		public Level2()
		{
			// assigns the file location to the background sound 
			backSound.SoundLocation = "night.wav";

			InitializeComponent();
			// the objective label that instructs the user on what to do
			lblObjective.Text = ("OBJ: Obtain the sword");
			// the label that displays the lives the user has remaining
			// instructs the user on how to complete the level
			lblLives.Text = ("Lives:" + lives);

			// plays the background music
			backSound.PlayLooping();

			



		}

		/* allows the user to pass a audio file location as an argument and plays the sound 
		 utilizing media player */
		private void Play(String audioPath) 
		{
			MediaPlayer myPlayer = new MediaPlayer();
			myPlayer.Open(new System.Uri(audioPath));
			myPlayer.Play();
		}
		// removes a life and checks to see when the user has lost all his lives 
		private int UpdateLives(ref int livesRemaining)
		{
			livesRemaining = livesRemaining - 1;

			if (livesRemaining == 0)
			{
				//  stop the timer
				gameTimer.Stop();
				// stops the background music
				backSound.Stop();
				// shows the game over screen
				LoseScreen theForm = new LoseScreen();
				this.Hide();
				theForm.ShowDialog();
				this.Close();
			}

			return livesRemaining;
		}





		private void mainGameTimer(object sender, EventArgs e)
		{

			// linking the jumpspeed integer with the player picture boxes to location
			player.Top += jumpSpeed;

			// refresh the player picture box consistently
			player.Refresh();

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
			if (goleft && player.Left > 100)
			{
				player.Left -= playSpeed;
			}
			// by doing the if statement above, the player picture will stop

			// if go right Bool is true
			// player left plus players width plus 100 is less than the forms width
			// then we move the player towards the right by adding to the players left
			if (goright && player.Left + (player.Width + 100) < this.ClientSize.Width)
			{
				player.Left += playSpeed;
			}
			// by doing the if statement above , the player picture will stop on the forms right

			//if go right is true and the background picture left is greater 1352
			// then we move the background picture towards the left
			if (goright && background.Left > -1353)
			{
				background.Left -= backLeft;


				// the for loop below is checking to see the platforms and coins in the level.
				// when they are found it will move them towards the left 
				foreach (Control x in this.Controls)
				{
					if (x is PictureBox && (String)x.Tag == "platform" || x is PictureBox && (String)x.Tag == "coin" || x is PictureBox && (String)x.Tag == "door" ||
						x is PictureBox && (String)x.Tag == "sword" || x is PictureBox && (String)x.Tag == "monster" || x is PictureBox && (String)x.Tag == "flame" || 
						x is PictureBox && (String)x.Tag == "slowPortal" || x is PictureBox && (String)x.Tag == "portal" || x is PictureBox && (String)x.Tag == "bat")
					{
						x.Left -= backLeft;
					}


				}
			}
			// if go left is true and the background pictures left is less than 2
			// then we move the background picture towards the right
			if (goleft && background.Left < 2)
			{
				background.Left += backLeft;

				// below the is the for loop thats checking to see the platforms and coins in the level
				// when they are found in the level it will move them all towards the right with the background 
				foreach (Control x in this.Controls)
				{
					if (x is PictureBox && (String)x.Tag == "platform" || x is PictureBox && (String)x.Tag == "coin" || x is PictureBox && (String)x.Tag == "door" ||
						x is PictureBox && (String)x.Tag == "sword" || x is PictureBox && (String)x.Tag == "monster" || x is PictureBox && (String)x.Tag == "flame" ||
						x is PictureBox && (String)x.Tag == "slowPortal" || x is PictureBox && (String)x.Tag == "portal" || x is PictureBox && (String)x.Tag == "bat")
					{
						x.Left += backLeft;
					}
				}
			}

			// below if the for loop thats checking for all of the controls in this form
			foreach (Control x in this.Controls)
			{
				// is X is a picture box and it has a tag of a platform
				if (x is PictureBox && (String)x.Tag == "platform")
				{
					// then we are checking if the player is colliding with the platform
					// and jumping is set to false
					if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
					{
						// then we do the following 
						// set the force to 8
						force = 8;
						player.Top = x.Top - player.Height; // also we place the player on top of the picture box
						jumpSpeed = 0; // set the jump speed to 0
					}
				}
				// is X is a picture box and it has a tag of a platform
				if (x is PictureBox && (String)x.Tag == "slowPortal")
				{
					// then we are checking if the player is colliding with the portal
					// and jumping is set to false
					if (player.Bounds.IntersectsWith(x.Bounds) )
					{
						// plays a sound
						Play(Application.StartupPath + "\\Portal.mp3");

						// removes a life
						UpdateLives(ref lives);
						// updates the lives label
						lblLives.Text = ("Lives:" + lives);
						this.Controls.Remove(x); // then we are going to remove the portal image 



					}
				}
				// is X is a picture box and it has a tag of a platform
				if (x is PictureBox && (String)x.Tag == "portal")
					{
						// then we are checking if the player is colliding with the platform
						// and jumping is set to false
						if (player.Bounds.IntersectsWith(x.Bounds) )
						{
						// stops the timer
						gameTimer.Stop();
						// stops the background music
						backSound.Stop();
						// displays the win screen
						LoseScreen theForm = new LoseScreen();
						this.Hide();
						theForm.ShowDialog();
						this.Close();
						
						}

					}
				// if the picture box found has a tag of a coin 
				if (x is PictureBox && (String)x.Tag == "bat")
				{
					// now if the player collides with the pic box
					if (player.Bounds.IntersectsWith(x.Bounds))
					{
						this.Controls.Remove(x); // then we are going to remove the coin image 
						if (hasSword == true)
						{
							Play(Application.StartupPath + "\\bat.mp3");

							score++; // add 1 to the score
							lblBats.Text = ("Bats defeated:" + score);
						}
						else if (hasSword == false)
						{
							// you lose a life
							
							UpdateLives(ref lives);
							lblLives.Text = ("Lives:" + lives);


						}

					}
				}
				// if the picture box found has a tag of a coin 
				if (x is PictureBox && (String)x.Tag == "sword")
				{
					// now if the player collides with the pic box
					if (player.Bounds.IntersectsWith(sword.Bounds))
					{
						// plays the sound
						Play(Application.StartupPath + "\\sword.mp3");
						// shows obj label to instruct the user
						lblObjective.Text = ("OBJ: Defeat the Beast");
						this.Controls.Remove(sword); // then we are going to remove the sword image 
						player.Image = Properties.Resources.newPlayerSword;
						// change the has sword boolean to true
						hasSword = true;
					}

				}

			}

			// if the player collides with the monster and has sword boolean is true

			if (player.Bounds.IntersectsWith(monster.Bounds) && hasSword)
			{
				// and stop the timer
				gameTimer.Stop();
				// stops the background music
				backSound.Stop();
				// displays the win screen
				Level3 theForm = new Level3();
				this.Hide();
				theForm.ShowDialog();
				this.Close();
				

			}
			// if the player collides with the beast and the sword boolean is false
			if (player.Bounds.IntersectsWith(monster.Bounds) && hasSword == false)
			{

				//  stop the timer
				gameTimer.Stop();
				// stops the background music
				backSound.Stop();
				// shows the game over screen
				LoseScreen theForm = new LoseScreen();
				this.Hide();
				theForm.ShowDialog();
				this.Close();

			}





				// this is where the player dies
				// if the player goes below the forms height then we will end the game
				if (player.Top + player.Height > this.ClientSize.Height + 60)
			{
				gameTimer.Stop();// stop the timer
				// stops the background music
				backSound.Stop();
				// the loss screen will be displayed
				LoseScreen theForm = new LoseScreen();
				this.Hide();
				theForm.ShowDialog();
				this.Close();
			}


		}

		private void keyisdown(object sender, KeyEventArgs e)
		{
			// if the player pressed the left key AND the player is inside the panel 
			// then we set the car left boolean to be true
			if (e.KeyCode == Keys.Left)
			{
				goleft = true;
				if (hasSword == true)
				{
					player.Image = Properties.Resources.newPlayer2;

				}
				else if (hasSword == false)
				{
					player.Image = Properties.Resources.newPlayerSword2;
				}
			}

			// if player pressed the right key and the player left plus player width is less than the panell width

			if (e.KeyCode == Keys.Right)
			{
				// then we set the plater right to be true
				goright = true;
				if (hasSword == true)
				{
					player.Image = Properties.Resources.newPlayer;

				}
				else if (hasSword == false)
				{
					player.Image = Properties.Resources.newPlayerSword;
				}
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

		private void lblLives_Click(object sender, EventArgs e)
		{

		}
	}
}

		