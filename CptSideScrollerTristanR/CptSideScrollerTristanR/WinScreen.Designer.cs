namespace CptSideScrollerTristanR
{
	partial class WinScreen
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
			this.lblYouWin = new System.Windows.Forms.Label();
			this.btnBack = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::CptSideScrollerTristanR.Properties.Resources.platform;
			this.pictureBox1.Location = new System.Drawing.Point(0, 397);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(799, 57);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// lblYouWin
			// 
			this.lblYouWin.AutoSize = true;
			this.lblYouWin.BackColor = System.Drawing.Color.Transparent;
			this.lblYouWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblYouWin.ForeColor = System.Drawing.Color.Yellow;
			this.lblYouWin.Location = new System.Drawing.Point(342, 129);
			this.lblYouWin.Name = "lblYouWin";
			this.lblYouWin.Size = new System.Drawing.Size(115, 31);
			this.lblYouWin.TabIndex = 1;
			this.lblYouWin.Text = "You Win";
			// 
			// btnBack
			// 
			this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.ForeColor = System.Drawing.Color.Coral;
			this.btnBack.Location = new System.Drawing.Point(348, 217);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(109, 50);
			this.btnBack.TabIndex = 2;
			this.btnBack.Text = "Back\r\n";
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// WinScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CptSideScrollerTristanR.Properties.Resources._37_affinity_game_background_600;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.lblYouWin);
			this.Controls.Add(this.pictureBox1);
			this.Name = "WinScreen";
			this.Text = "WinScreen";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblYouWin;
		private System.Windows.Forms.Button btnBack;
	}
}