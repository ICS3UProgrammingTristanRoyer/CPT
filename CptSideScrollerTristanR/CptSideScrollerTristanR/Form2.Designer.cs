namespace CptSideScrollerTristanR
{
	partial class Form2
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
			this.prbProgressBar = new System.Windows.Forms.ProgressBar();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.lblLoading = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblTips = new System.Windows.Forms.Label();
			this.tipTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// prbProgressBar
			// 
			this.prbProgressBar.BackColor = System.Drawing.Color.DarkRed;
			this.prbProgressBar.Location = new System.Drawing.Point(231, 238);
			this.prbProgressBar.Name = "prbProgressBar";
			this.prbProgressBar.Size = new System.Drawing.Size(139, 37);
			this.prbProgressBar.TabIndex = 1;
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// lblLoading
			// 
			this.lblLoading.AutoSize = true;
			this.lblLoading.BackColor = System.Drawing.Color.DarkRed;
			this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLoading.Location = new System.Drawing.Point(224, 168);
			this.lblLoading.Name = "lblLoading";
			this.lblLoading.Size = new System.Drawing.Size(157, 39);
			this.lblLoading.TabIndex = 2;
			this.lblLoading.Text = "Loading.";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::CptSideScrollerTristanR.Properties.Resources.purpleFlames;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(600, 484);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// lblTips
			// 
			this.lblTips.AutoSize = true;
			this.lblTips.BackColor = System.Drawing.Color.Aqua;
			this.lblTips.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTips.Location = new System.Drawing.Point(12, 336);
			this.lblTips.Name = "lblTips";
			this.lblTips.Size = new System.Drawing.Size(28, 25);
			this.lblTips.TabIndex = 3;
			this.lblTips.Text = "--";
			// 
			// tipTimer
			// 
			this.tipTimer.Enabled = true;
			this.tipTimer.Interval = 800;
			this.tipTimer.Tick += new System.EventHandler(this.tipTimer_Tick);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CptSideScrollerTristanR.Properties.Resources.purpleFlames;
			this.ClientSize = new System.Drawing.Size(599, 481);
			this.Controls.Add(this.lblTips);
			this.Controls.Add(this.lblLoading);
			this.Controls.Add(this.prbProgressBar);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form2";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ProgressBar prbProgressBar;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Label lblLoading;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblTips;
		private System.Windows.Forms.Timer tipTimer;
	}
}