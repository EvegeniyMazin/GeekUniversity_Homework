namespace HW7
{
	partial class Doubler
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.Plusone = new System.Windows.Forms.Button();
			this.Reset = new System.Windows.Forms.Button();
			this.Multiply = new System.Windows.Forms.Button();
			this.CountViewer = new System.Windows.Forms.Label();
			this.ClickCount = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Undo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Plusone
			// 
			this.Plusone.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Plusone.Location = new System.Drawing.Point(1078, 107);
			this.Plusone.Name = "Plusone";
			this.Plusone.Size = new System.Drawing.Size(182, 86);
			this.Plusone.TabIndex = 0;
			this.Plusone.Text = "+1";
			this.Plusone.UseVisualStyleBackColor = true;
			this.Plusone.Click += new System.EventHandler(this.button1_Click);
			// 
			// Reset
			// 
			this.Reset.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Reset.Location = new System.Drawing.Point(1078, 368);
			this.Reset.Name = "Reset";
			this.Reset.Size = new System.Drawing.Size(182, 82);
			this.Reset.TabIndex = 1;
			this.Reset.Text = "Reset";
			this.Reset.UseVisualStyleBackColor = true;
			this.Reset.Click += new System.EventHandler(this.button2_Click);
			// 
			// Multiply
			// 
			this.Multiply.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Multiply.Location = new System.Drawing.Point(1078, 232);
			this.Multiply.Name = "Multiply";
			this.Multiply.Size = new System.Drawing.Size(182, 85);
			this.Multiply.TabIndex = 2;
			this.Multiply.Text = "x2";
			this.Multiply.UseVisualStyleBackColor = true;
			this.Multiply.Click += new System.EventHandler(this.button3_Click);
			// 
			// CountViewer
			// 
			this.CountViewer.AutoSize = true;
			this.CountViewer.Location = new System.Drawing.Point(280, 316);
			this.CountViewer.Name = "CountViewer";
			this.CountViewer.Size = new System.Drawing.Size(35, 37);
			this.CountViewer.TabIndex = 3;
			this.CountViewer.Text = "0";
			// 
			// ClickCount
			// 
			this.ClickCount.AutoSize = true;
			this.ClickCount.Location = new System.Drawing.Point(300, 502);
			this.ClickCount.Name = "ClickCount";
			this.ClickCount.Size = new System.Drawing.Size(0, 37);
			this.ClickCount.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(287, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 37);
			this.label1.TabIndex = 5;
			// 
			// Undo
			// 
			this.Undo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Undo.Location = new System.Drawing.Point(1078, 489);
			this.Undo.Name = "Undo";
			this.Undo.Size = new System.Drawing.Size(182, 83);
			this.Undo.TabIndex = 6;
			this.Undo.Text = "Undo";
			this.Undo.UseVisualStyleBackColor = true;
			this.Undo.Click += new System.EventHandler(this.Undo_Click);
			// 
			// Doubler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1498, 880);
			this.Controls.Add(this.Undo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ClickCount);
			this.Controls.Add(this.CountViewer);
			this.Controls.Add(this.Multiply);
			this.Controls.Add(this.Reset);
			this.Controls.Add(this.Plusone);
			this.Name = "Doubler";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Plusone;
		private System.Windows.Forms.Button Reset;
		private System.Windows.Forms.Button Multiply;
		private System.Windows.Forms.Label CountViewer;
		private System.Windows.Forms.Label ClickCount;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Undo;
	}
}

