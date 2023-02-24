namespace primenumbers
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
			this.submitBtn = new System.Windows.Forms.Button();
			this.numberTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// submitBtn
			// 
			this.submitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.submitBtn.Location = new System.Drawing.Point(339, 155);
			this.submitBtn.Name = "submitBtn";
			this.submitBtn.Size = new System.Drawing.Size(99, 45);
			this.submitBtn.TabIndex = 0;
			this.submitBtn.Text = "Submit";
			this.submitBtn.UseVisualStyleBackColor = false;
			this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
			// 
			// numberTextBox
			// 
			this.numberTextBox.Location = new System.Drawing.Point(339, 74);
			this.numberTextBox.Name = "numberTextBox";
			this.numberTextBox.Size = new System.Drawing.Size(100, 20);
			this.numberTextBox.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.numberTextBox);
			this.Controls.Add(this.submitBtn);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button submitBtn;
		private System.Windows.Forms.TextBox numberTextBox;
	}
}

