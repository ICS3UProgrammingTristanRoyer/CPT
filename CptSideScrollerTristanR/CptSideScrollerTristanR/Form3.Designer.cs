﻿namespace CptSideScrollerTristanR
{
	partial class Form3
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.gameTimer = new System.Windows.Forms.Timer(this.components);
			this.txtCoins = new System.Windows.Forms.Label();
			this.armor = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox27 = new System.Windows.Forms.PictureBox();
			this.pictureBox26 = new System.Windows.Forms.PictureBox();
			this.pictureBox25 = new System.Windows.Forms.PictureBox();
			this.pictureBox24 = new System.Windows.Forms.PictureBox();
			this.pictureBox23 = new System.Windows.Forms.PictureBox();
			this.pictureBox22 = new System.Windows.Forms.PictureBox();
			this.pictureBox21 = new System.Windows.Forms.PictureBox();
			this.pictureBox20 = new System.Windows.Forms.PictureBox();
			this.pictureBox19 = new System.Windows.Forms.PictureBox();
			this.pictureBox18 = new System.Windows.Forms.PictureBox();
			this.pictureBox17 = new System.Windows.Forms.PictureBox();
			this.pictureBox16 = new System.Windows.Forms.PictureBox();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.player = new System.Windows.Forms.PictureBox();
			this.key = new System.Windows.Forms.PictureBox();
			this.coin = new System.Windows.Forms.PictureBox();
			this.door = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.background = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.armor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.key)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.door)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			this.SuspendLayout();
			// 
			// gameTimer
			// 
			this.gameTimer.Enabled = true;
			this.gameTimer.Interval = 20;
			this.gameTimer.Tick += new System.EventHandler(this.mainGameTimer);
			// 
			// txtCoins
			// 
			this.txtCoins.AutoSize = true;
			this.txtCoins.BackColor = System.Drawing.Color.DarkBlue;
			this.txtCoins.ForeColor = System.Drawing.Color.DarkRed;
			this.txtCoins.Location = new System.Drawing.Point(2214, 9);
			this.txtCoins.Name = "txtCoins";
			this.txtCoins.Size = new System.Drawing.Size(36, 13);
			this.txtCoins.TabIndex = 29;
			this.txtCoins.Text = "Coins:";
			// 
			// armor
			// 
			this.armor.BackColor = System.Drawing.Color.Transparent;
			this.armor.Image = global::CptSideScrollerTristanR.Properties.Resources.newPlayer;
			this.armor.Location = new System.Drawing.Point(495, 361);
			this.armor.Name = "armor";
			this.armor.Size = new System.Drawing.Size(58, 60);
			this.armor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.armor.TabIndex = 30;
			this.armor.TabStop = false;
			this.armor.Tag = "armor";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::CptSideScrollerTristanR.Properties.Resources.platform;
			this.pictureBox1.Location = new System.Drawing.Point(1819, 404);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(105, 29);
			this.pictureBox1.TabIndex = 28;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Tag = "platform";
			// 
			// pictureBox27
			// 
			this.pictureBox27.BackgroundImage = global::CptSideScrollerTristanR.Properties.Resources.platform;
			this.pictureBox27.Location = new System.Drawing.Point(1733, 69);
			this.pictureBox27.Name = "pictureBox27";
			this.pictureBox27.Size = new System.Drawing.Size(127, 29);
			this.pictureBox27.TabIndex = 27;
			this.pictureBox27.TabStop = false;
			this.pictureBox27.Tag = "platform";
			// 
			// pictureBox26
			// 
			this.pictureBox26.BackgroundImage = global::CptSideScrollerTristanR.Properties.Resources.platform;
			this.pictureBox26.Location = new System.Drawing.Point(1610, 330);
			this.pictureBox26.Name = "pictureBox26";
			this.pictureBox26.Size = new System.Drawing.Size(125, 29);
			this.pictureBox26.TabIndex = 26;
			this.pictureBox26.TabStop = false;
			this.pictureBox26.Tag = "platform";
			// 
			// pictureBox25
			// 
			this.pictureBox25.Image = global::CptSideScrollerTristanR.Properties.Resources.newCoin;
			this.pictureBox25.Location = new System.Drawing.Point(1649, 300);
			this.pictureBox25.Name = "pictureBox25";
			this.pictureBox25.Size = new System.Drawing.Size(33, 30);
			this.pictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox25.TabIndex = 25;
			this.pictureBox25.TabStop = false;
			this.pictureBox25.Tag = "coin";
			// 
			// pictureBox24
			// 
			this.pictureBox24.Image = global::CptSideScrollerTristanR.Properties.Resources.newCoin;
			this.pictureBox24.Location = new System.Drawing.Point(1583, 404);
			this.pictureBox24.Name = "pictureBox24";
			this.pictureBox24.Size = new System.Drawing.Size(33, 30);
			this.pictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox24.TabIndex = 24;
			this.pictureBox24.TabStop = false;
			this.pictureBox24.Tag = "coin";
			// 
			// pictureBox23
			// 
			this.pictureBox23.Image = global::CptSideScrollerTristanR.Properties.Resources.newCoin;
			this.pictureBox23.Location = new System.Drawing.Point(1547, 364);
			this.pictureBox23.Name = "pictureBox23";
			this.pictureBox23.Size = new System.Drawing.Size(33, 30);
			this.pictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox23.TabIndex = 23;
			this.pictureBox23.TabStop = false;
			this.pictureBox23.Tag = "coin";
			// 
			// pictureBox22
			// 
			this.pictureBox22.Image = global::CptSideScrollerTristanR.Properties.Resources.newCoin;
			this.pictureBox22.Location = new System.Drawing.Point(1499, 329);
			this.pictureBox22.Name = "pictureBox22";
			this.pictureBox22.Size = new System.Drawing.Size(33, 30);
			this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox22.TabIndex = 22;
			this.pictureBox22.TabStop = false;
			this.pictureBox22.Tag = "coin";
			// 
			// pictureBox21
			// 
			this.pictureBox21.Image = global::CptSideScrollerTristanR.Properties.Resources.newCoin;
			this.pictureBox21.Location = new System.Drawing.Point(1455, 364);
			this.pictureBox21.Name = "pictureBox21";
			this.pictureBox21.Size = new System.Drawing.Size(33, 30);
			this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox21.TabIndex = 21;
			this.pictureBox21.TabStop = false;
			this.pictureBox21.Tag = "coin";
			// 
			// pictureBox20
			// 
			this.pictureBox20.Image = global::CptSideScrollerTristanR.Properties.Resources.newCoin;
			this.pictureBox20.Location = new System.Drawing.Point(1499, 404);
			this.pictureBox20.Name = "pictureBox20";
			this.pictureBox20.Size = new System.Drawing.Size(33, 30);
			this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox20.TabIndex = 20;
			this.pictureBox20.TabStop = false;
			this.pictureBox20.Tag = "coin";
			// 
			// pictureBox19
			// 
			this.pictureBox19.Image = global::CptSideScrollerTristanR.Properties.Resources.newCoin;
			this.pictureBox19.Location = new System.Drawing.Point(1412, 404);
			this.pictureBox19.Name = "pictureBox19";
			this.pictureBox19.Size = new System.Drawing.Size(33, 30);
			this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox19.TabIndex = 19;
			this.pictureBox19.TabStop = false;
			this.pictureBox19.Tag = "coin";
			// 
			// pictureBox18
			// 
			this.pictureBox18.BackgroundImage = global::CptSideScrollerTristanR.Properties.Resources.platform;
			this.pictureBox18.Location = new System.Drawing.Point(1362, 451);
			this.pictureBox18.Name = "pictureBox18";
			this.pictureBox18.Size = new System.Drawing.Size(290, 29);
			this.pictureBox18.TabIndex = 18;
			this.pictureBox18.TabStop = false;
			this.pictureBox18.Tag = "platform";
			// 
			// pictureBox17
			// 
			this.pictureBox17.BackgroundImage = global::CptSideScrollerTristanR.Properties.Resources.platform;
			this.pictureBox17.Location = new System.Drawing.Point(660, 320);
			this.pictureBox17.Name = "pictureBox17";
			this.pictureBox17.Size = new System.Drawing.Size(281, 50);
			this.pictureBox17.TabIndex = 17;
			this.pictureBox17.TabStop = false;
			this.pictureBox17.Tag = "platform";
			// 
			// pictureBox16
			// 
			this.pictureBox16.BackgroundImage = global::CptSideScrollerTristanR.Properties.Resources.platform;
			this.pictureBox16.Location = new System.Drawing.Point(216, 215);
			this.pictureBox16.Name = "pictureBox16";
			this.pictureBox16.Size = new System.Drawing.Size(112, 50);
			this.pictureBox16.TabIndex = 16;
			this.pictureBox16.TabStop = false;
			this.pictureBox16.Tag = "platform";
			// 
			// pictureBox15
			// 
			this.pictureBox15.Image = global::CptSideScrollerTristanR.Properties.Resources.newCoin;
			this.pictureBox15.Location = new System.Drawing.Point(253, 179);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(37, 30);
			this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox15.TabIndex = 15;
			this.pictureBox15.TabStop = false;
			this.pictureBox15.Tag = "coin";
			// 
			// pictureBox14
			// 
			this.pictureBox14.Image = global::CptSideScrollerTristanR.Properties.Resources.newCoin;
			this.pictureBox14.Location = new System.Drawing.Point(1322, 293);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(35, 30);
			this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox14.TabIndex = 14;
			this.pictureBox14.TabStop = false;
			this.pictureBox14.Tag = "coin";
			// 
			// pictureBox13
			// 
			this.pictureBox13.BackgroundImage = global::CptSideScrollerTristanR.Properties.Resources.platform;
			this.pictureBox13.Location = new System.Drawing.Point(1292, 320);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(112, 50);
			this.pictureBox13.TabIndex = 13;
			this.pictureBox13.TabStop = false;
			this.pictureBox13.Tag = "platform";
			// 
			// pictureBox12
			// 
			this.pictureBox12.Image = global::CptSideScrollerTristanR.Properties.Resources.newCoin;
			this.pictureBox12.Location = new System.Drawing.Point(1627, 208);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(35, 30);
			this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox12.TabIndex = 12;
			this.pictureBox12.TabStop = false;
			this.pictureBox12.Tag = "coin";
			// 
			// pictureBox9
			// 
			this.pictureBox9.BackgroundImage = global::CptSideScrollerTristanR.Properties.Resources.platform;
			this.pictureBox9.Location = new System.Drawing.Point(1591, 244);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(112, 50);
			this.pictureBox9.TabIndex = 11;
			this.pictureBox9.TabStop = false;
			this.pictureBox9.Tag = "platform";
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = global::CptSideScrollerTristanR.Properties.Resources.newCoin;
			this.pictureBox8.Location = new System.Drawing.Point(485, 268);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(35, 30);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox8.TabIndex = 10;
			this.pictureBox8.TabStop = false;
			this.pictureBox8.Tag = "coin";
			// 
			// pictureBox11
			// 
			this.pictureBox11.BackgroundImage = global::CptSideScrollerTristanR.Properties.Resources.platform;
			this.pictureBox11.Location = new System.Drawing.Point(1024, 320);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(112, 50);
			this.pictureBox11.TabIndex = 9;
			this.pictureBox11.TabStop = false;
			this.pictureBox11.Tag = "platform";
			// 
			// pictureBox10
			// 
			this.pictureBox10.BackgroundImage = global::CptSideScrollerTristanR.Properties.Resources.platform;
			this.pictureBox10.Location = new System.Drawing.Point(0, 164);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(112, 50);
			this.pictureBox10.TabIndex = 8;
			this.pictureBox10.TabStop = false;
			this.pictureBox10.Tag = "platform";
			// 
			// player
			// 
			this.player.Image = global::CptSideScrollerTristanR.Properties.Resources.player;
			this.player.Location = new System.Drawing.Point(0, 351);
			this.player.Name = "player";
			this.player.Size = new System.Drawing.Size(50, 60);
			this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.player.TabIndex = 7;
			this.player.TabStop = false;
			this.player.Tag = "player";
			// 
			// key
			// 
			this.key.BackgroundImage = global::CptSideScrollerTristanR.Properties.Resources.purpleFlames;
			this.key.Image = global::CptSideScrollerTristanR.Properties.Resources.key2;
			this.key.Location = new System.Drawing.Point(1751, 25);
			this.key.Name = "key";
			this.key.Size = new System.Drawing.Size(90, 47);
			this.key.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.key.TabIndex = 6;
			this.key.TabStop = false;
			this.key.Tag = "key";
			// 
			// coin
			// 
			this.coin.Image = global::CptSideScrollerTristanR.Properties.Resources.newCoin;
			this.coin.Location = new System.Drawing.Point(1061, 293);
			this.coin.Name = "coin";
			this.coin.Size = new System.Drawing.Size(35, 30);
			this.coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.coin.TabIndex = 6;
			this.coin.TabStop = false;
			this.coin.Tag = "coin";
			// 
			// door
			// 
			this.door.Image = global::CptSideScrollerTristanR.Properties.Resources.Closed_Door;
			this.door.Location = new System.Drawing.Point(24, 105);
			this.door.Name = "door";
			this.door.Size = new System.Drawing.Size(56, 62);
			this.door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.door.TabIndex = 3;
			this.door.TabStop = false;
			this.door.Tag = "door";
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackgroundImage = global::CptSideScrollerTristanR.Properties.Resources.platform;
			this.pictureBox3.Location = new System.Drawing.Point(444, 295);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(109, 50);
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Tag = "platform";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = global::CptSideScrollerTristanR.Properties.Resources.platform;
			this.pictureBox2.Location = new System.Drawing.Point(0, 417);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(553, 63);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Tag = "platform";
			// 
			// background
			// 
			this.background.Image = global::CptSideScrollerTristanR.Properties.Resources.Background;
			this.background.Location = new System.Drawing.Point(0, 0);
			this.background.Name = "background";
			this.background.Size = new System.Drawing.Size(2000, 600);
			this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.background.TabIndex = 0;
			this.background.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::CptSideScrollerTristanR.Properties.Resources.purpleFlames;
			this.pictureBox4.Location = new System.Drawing.Point(602, 451);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(583, 29);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 31;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Tag = "flame";
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = global::CptSideScrollerTristanR.Properties.Resources.purpleFlames;
			this.pictureBox5.Location = new System.Drawing.Point(1235, 451);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(130, 29);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 32;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Tag = "flame";
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = global::CptSideScrollerTristanR.Properties.Resources.purpleFlames;
			this.pictureBox6.Location = new System.Drawing.Point(1649, 451);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(120, 29);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 33;
			this.pictureBox6.TabStop = false;
			this.pictureBox6.Tag = "flame";
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = global::CptSideScrollerTristanR.Properties.Resources.purpleFlames;
			this.pictureBox7.Location = new System.Drawing.Point(1819, 451);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(105, 28);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox7.TabIndex = 34;
			this.pictureBox7.TabStop = false;
			this.pictureBox7.Tag = "flame";
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(598, 481);
			this.Controls.Add(this.pictureBox7);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.armor);
			this.Controls.Add(this.txtCoins);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox27);
			this.Controls.Add(this.pictureBox26);
			this.Controls.Add(this.pictureBox25);
			this.Controls.Add(this.pictureBox24);
			this.Controls.Add(this.pictureBox23);
			this.Controls.Add(this.pictureBox22);
			this.Controls.Add(this.pictureBox21);
			this.Controls.Add(this.pictureBox20);
			this.Controls.Add(this.pictureBox19);
			this.Controls.Add(this.pictureBox18);
			this.Controls.Add(this.pictureBox17);
			this.Controls.Add(this.pictureBox16);
			this.Controls.Add(this.pictureBox15);
			this.Controls.Add(this.pictureBox14);
			this.Controls.Add(this.pictureBox13);
			this.Controls.Add(this.pictureBox12);
			this.Controls.Add(this.pictureBox9);
			this.Controls.Add(this.pictureBox8);
			this.Controls.Add(this.pictureBox11);
			this.Controls.Add(this.pictureBox10);
			this.Controls.Add(this.player);
			this.Controls.Add(this.key);
			this.Controls.Add(this.coin);
			this.Controls.Add(this.door);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.background);
			this.Name = "Form3";
			this.Text = "Form3";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
			((System.ComponentModel.ISupportInitialize)(this.armor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.key)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.door)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox background;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox door;
		private System.Windows.Forms.PictureBox coin;
		private System.Windows.Forms.PictureBox key;
		private System.Windows.Forms.PictureBox player;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.PictureBox pictureBox13;
		private System.Windows.Forms.PictureBox pictureBox14;
		private System.Windows.Forms.PictureBox pictureBox15;
		private System.Windows.Forms.PictureBox pictureBox16;
		private System.Windows.Forms.PictureBox pictureBox17;
		private System.Windows.Forms.PictureBox pictureBox18;
		private System.Windows.Forms.PictureBox pictureBox19;
		private System.Windows.Forms.PictureBox pictureBox20;
		private System.Windows.Forms.PictureBox pictureBox21;
		private System.Windows.Forms.PictureBox pictureBox22;
		private System.Windows.Forms.PictureBox pictureBox23;
		private System.Windows.Forms.PictureBox pictureBox24;
		private System.Windows.Forms.PictureBox pictureBox25;
		private System.Windows.Forms.PictureBox pictureBox26;
		private System.Windows.Forms.PictureBox pictureBox27;
		private System.Windows.Forms.Timer gameTimer;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label txtCoins;
		private System.Windows.Forms.PictureBox armor;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox7;
	}
}