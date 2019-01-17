namespace CptSideScrollerTristanR
{
	partial class Level3
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
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pillar = new System.Windows.Forms.PictureBox();
			this.player = new System.Windows.Forms.PictureBox();
			this.player2 = new System.Windows.Forms.PictureBox();
			this.gameTimer = new System.Windows.Forms.Timer(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pillar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.BackgroundImage = global::CptSideScrollerTristanR.Properties.Resources.grass2;
			this.pictureBox2.Location = new System.Drawing.Point(2, 452);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(319, 50);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Tag = "platform";
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// pillar
			// 
			this.pillar.Image = global::CptSideScrollerTristanR.Properties.Resources.Pillar;
			this.pillar.Location = new System.Drawing.Point(310, -2);
			this.pillar.Name = "pillar";
			this.pillar.Size = new System.Drawing.Size(37, 456);
			this.pillar.TabIndex = 2;
			this.pillar.TabStop = false;
			this.pillar.Tag = "pillar";
			// 
			// player
			// 
			this.player.BackColor = System.Drawing.Color.Transparent;
			this.player.Image = global::CptSideScrollerTristanR.Properties.Resources.player;
			this.player.Location = new System.Drawing.Point(12, 396);
			this.player.Name = "player";
			this.player.Size = new System.Drawing.Size(51, 58);
			this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.player.TabIndex = 3;
			this.player.TabStop = false;
			this.player.Tag = "player";
			// 
			// player2
			// 
			this.player2.BackColor = System.Drawing.Color.Transparent;
			this.player2.Image = global::CptSideScrollerTristanR.Properties.Resources.newPlayerSword21;
			this.player2.Location = new System.Drawing.Point(593, 388);
			this.player2.Name = "player2";
			this.player2.Size = new System.Drawing.Size(56, 58);
			this.player2.TabIndex = 4;
			this.player2.TabStop = false;
			this.player2.Tag = "player2";
			// 
			// gameTimer
			// 
			this.gameTimer.Enabled = true;
			this.gameTimer.Interval = 20;
			this.gameTimer.Tick += new System.EventHandler(this.mainGameTimer);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::CptSideScrollerTristanR.Properties.Resources.platform;
			this.pictureBox1.Location = new System.Drawing.Point(338, 452);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(311, 50);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Tag = "platform";
			// 
			// Level3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CptSideScrollerTristanR.Properties.Resources.LastBackground;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(650, 489);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.player2);
			this.Controls.Add(this.player);
			this.Controls.Add(this.pillar);
			this.Controls.Add(this.pictureBox2);
			this.Name = "Level3";
			this.Text = "Level3";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pillar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pillar;
		private System.Windows.Forms.PictureBox player;
		private System.Windows.Forms.PictureBox player2;
		private System.Windows.Forms.Timer gameTimer;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}