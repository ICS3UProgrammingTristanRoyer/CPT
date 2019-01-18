/*
 * Created by: Tristan Royer
 * Finished on: 16 - 1 - 2019
 * Created for: ICS3U Programming
 * CPT
 * This program is a game created by following a tutorial for "side scrolling game" by MOO ICT
 * this game also utilizies extra code obtained through research.
*/
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
		// allows sound to be played
		System.Media.SoundPlayer backSound = new System.Media.SoundPlayer();

		public Form1()
		{
			// aborts the load to allow the splash screen to be shown first
			Thread load = new Thread(new ThreadStart(StartSplash));
			load.Start();
			Thread.Sleep(2600);
			load.Abort();

			// assign the sound file to the variable
			backSound.SoundLocation = "Victory.wav";
			InitializeComponent();

			// play background sound.
			backSound.PlayLooping();

		}
		public void StartSplash()

		{
			// runs the splash screen before the menu appears
			Application.Run(new Form2());
		}

		

		private void btnStart_Click(object sender, EventArgs e)
		{
			// stops the music , closes this form and starts the game
			backSound.Stop();
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
