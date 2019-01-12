namespace CptSideScrollerTristanR
{
	partial class Form1
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
			this.btnStart = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnInstuctions = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.SystemColors.InfoText;
			this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStart.ForeColor = System.Drawing.Color.DarkRed;
			this.btnStart.Location = new System.Drawing.Point(353, 230);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(85, 23);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = false;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkRed;
			this.label1.Location = new System.Drawing.Point(297, 101);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(192, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Escape the Night";
			this.label1.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnInstuctions
			// 
			this.btnInstuctions.BackColor = System.Drawing.Color.Black;
			this.btnInstuctions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInstuctions.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnInstuctions.Location = new System.Drawing.Point(353, 289);
			this.btnInstuctions.Name = "btnInstuctions";
			this.btnInstuctions.Size = new System.Drawing.Size(85, 23);
			this.btnInstuctions.TabIndex = 2;
			this.btnInstuctions.Text = "Instructions";
			this.btnInstuctions.UseVisualStyleBackColor = false;
			this.btnInstuctions.Click += new System.EventHandler(this.btnInstuctions_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnInstuctions);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnStart);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnInstuctions;
	}
}

