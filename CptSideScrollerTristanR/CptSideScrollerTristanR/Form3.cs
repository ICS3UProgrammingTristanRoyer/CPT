﻿using System;
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
	public partial class Form3 : Form
	{

		bool goleft = false; // boolean which will control the character going left
		bool goright = false; // boolean which will control the character going right
		bool jumping = false; // boolean to check if the player is jumping or not
		bool hasKey = false; // boolean to determine if the player has obtained the key or not.
		bool hasArmor = false;// boolean to determine if the player has obtained the armor or not.

		int jumpSpeed = 10; // int to set the jump speed
		int force = 8; // force of the jump in an integer
		int score = 0; // default score int set to 0
	

		int playSpeed = 18; // this int will set the character's speed to 18
		int backLeft = 8; // this integer will set the background moving speed to 8
		// uses system media player for the music variable
		System.Media.SoundPlayer backSound = new System.Media.SoundPlayer();


		public Form3()
		{
			// assigns the background music
			backSound.SoundLocation = "night.wav";

			InitializeComponent();
			// instructs the user on how to complete the level
			lblObjective.Text = ("OBJ: Obtain the armor");

			// plays the background music
			backSound.PlayLooping();
			
			




		}
		// function that receives the audio file from the as an argument  and plays it
		private void Play(String audioPath)
		{
			MediaPlayer myPlayer = new MediaPlayer();
			myPlayer.Open(new System.Uri(audioPath));
			myPlayer.Play();
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
			// then change jump speed to -12
			// reduce force by 1
			if (jumping)
			{
				jumpSpeed = -12;
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
						x is PictureBox && (String)x.Tag == "key" || x is PictureBox && (String)x.Tag == "armor" || x is PictureBox && (String)x.Tag == "flame")
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
						x is PictureBox && (String)x.Tag == "key" || x is PictureBox && (String)x.Tag == "armor" || x is PictureBox && (String)x.Tag == "flame")
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
				// if the picture box found has a tag of a coin 
				if (x is PictureBox &&(String) x.Tag == "coin")
				{
					// now if the player collides with the pic box
					if (player.Bounds.IntersectsWith(x.Bounds))
					{
						// plays the coin sound effect
						Play(Application.StartupPath + "\\Coin.mp3");
						this.Controls.Remove(x); // then we are going to remove the coin image 
						score++; // add 1 to the score
						// updates the score label to display the score
						lblCoins.Text = ("Coins:" + score);
						


					}
				}
				// if the picture box found has a tag of a coin 
				if (x is PictureBox && (String)x.Tag == "armor")
				{
					// now if the player collides with the pic box
					if (player.Bounds.IntersectsWith(armor.Bounds))
					{
						// instructs the user on how to complete the level
						lblObjective.Text = ("OBJ: Obtain the Key");
						// play sound
						Play(Application.StartupPath + "\\armor.mp3");

						// removes the armor from the form
						this.Controls.Remove(armor); // then we are going to remove the armor image


						// changes the image of the player to the armor
						player.Image = Properties.Resources.newPlayerSword;
						// edits the boolean variable so that the game acknowledges the player has the armor
						hasArmor = true;
					}
				}
				if (x is PictureBox && (String)x.Tag == "key")
				{
					// if the player collides with the key picture box and has the armor

					if (player.Bounds.IntersectsWith(key.Bounds) && hasArmor == true)
					{

						// instructs the user on how to complete the level
						lblObjective.Text = ("OBJ: Return to the Portal");
						//play sound
						Play(Application.StartupPath + "\\Unlock.mp3");

						// changes the door to a portal
						door.Image = Properties.Resources.portal_2;

						// then we remove the key from the game
						this.Controls.Remove(key);
						// change the has key boolean to true
						hasKey = true;


					}
				}

			}

					// if the player collides with the door and has key  boolean is true along with the hasArmor boolean

				    if (player.Bounds.IntersectsWith(door.Bounds) && hasKey && hasArmor  )
					{
					// stop the timer
					gameTimer.Stop();
					// move to level 2
					Level2 theForm = new Level2();
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
				// shows the "you Lose" screen
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
			
				if (hasArmor == true)
				{
					player.Image = Properties.Resources.newPlayerSword2;

				}

			}

			// if player pressed the right key and the player left plus player width is less than the panell width

			if (e.KeyCode == Keys.Right)
			{
				// then we set the plater right to be true
				goright = true;

				if (hasArmor == true)
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
	}
}
