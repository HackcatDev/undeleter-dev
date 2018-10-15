
namespace UI
{
	partial class AboutBox
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Версия";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Дата сборки";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Автор";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 78);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Поддержать автора";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(131, 73);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(95, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Поддержать...";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(131, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "label5";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(131, 32);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 6;
			this.label6.Text = "label6";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(131, 55);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(87, 15);
			this.label7.TabIndex = 7;
			this.label7.Text = "Hackcat";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(12, 101);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(502, 128);
			this.label8.TabIndex = 8;
			this.label8.Text = resources.GetString("label8.Text");
			this.label8.Click += new System.EventHandler(this.Label8Click);
			// 
			// AboutBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(533, 221);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutBox";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "О программе Undeleter";
			this.Load += new System.EventHandler(this.AboutBoxLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
