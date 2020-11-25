namespace HW7
{
	partial class Menu
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
			this.Play = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Play
			// 
			this.Play.Location = new System.Drawing.Point(62, 129);
			this.Play.Name = "Play";
			this.Play.Size = new System.Drawing.Size(256, 153);
			this.Play.TabIndex = 0;
			this.Play.Text = "Reach the number";
			this.Play.UseVisualStyleBackColor = true;
			this.Play.Click += new System.EventHandler(this.Play_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(426, 129);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(257, 153);
			this.button1.TabIndex = 1;
			this.button1.Text = "Guess the number";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Play);
			this.Name = "Menu";
			this.Text = "Menu";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Play;
		private System.Windows.Forms.Button button1;
	}
}