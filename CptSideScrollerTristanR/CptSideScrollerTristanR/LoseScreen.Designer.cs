namespace CptSideScrollerTristanR
{
	partial class LoseScreen
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblYouLose = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnBack = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::CptSideScrollerTristanR.Properties.Resources._37_affinity_game_background_600;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(802, 452);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// lblYouLose
			// 
			this.lblYouLose.AutoSize = true;
			this.lblYouLose.BackColor = System.Drawing.Color.Red;
			this.lblYouLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblYouLose.Location = new System.Drawing.Point(247, 136);
			this.lblYouLose.Name = "lblYouLose";
			this.lblYouLose.Size = new System.Drawing.Size(136, 31);
			this.lblYouLose.TabIndex = 1;
			this.lblYouLose.Text = "You Lose";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::CptSideScrollerTristanR.Properties.Resources.purpleFlames;
			this.pictureBox2.Location = new System.Drawing.Point(0, 352);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(618, 100);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// btnBack
			// 
			this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.ForeColor = System.Drawing.Color.DarkRed;
			this.btnBack.Image = global::CptSideScrollerTristanR.Properties.Resources.purpleFlames;
			this.btnBack.Location = new System.Drawing.Point(208, 234);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(209, 50);
			this.btnBack.TabIndex = 3;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// LoseScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(618, 450);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.lblYouLose);
			this.Controls.Add(this.pictureBox1);
			this.Name = "LoseScreen";
			this.Text = "LoseScreen";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblYouLose;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button btnBack;
	}
}