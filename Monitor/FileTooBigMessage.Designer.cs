
namespace UI
{
	partial class FileTooBigMessage
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(578, 86);
			this.label1.TabIndex = 1;
			this.label1.Text = "Мы не знаем, как это могло случиться, так что выбор за вами. Файл, который вы хот" +
			"ите сохранить, слишком большой. Более подробная информация указана ниже.";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 139);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Имя файла";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 162);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Путь к файлу";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 185);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Размер файла";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 208);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(175, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "Максимальный размер копии";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(201, 139);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(384, 23);
			this.label6.TabIndex = 6;
			this.label6.Text = "label6";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(201, 162);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(384, 23);
			this.label7.TabIndex = 7;
			this.label7.Text = "label7";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(201, 185);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(384, 23);
			this.label8.TabIndex = 8;
			this.label8.Text = "label8";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(201, 208);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(384, 23);
			this.label9.TabIndex = 9;
			this.label9.Text = "label9";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(510, 234);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "Я понял";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// FileTooBigMessage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(597, 267);
			this.ControlBox = false;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FileTooBigMessage";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Ошибка создания копии: файл слишком большой";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.FileTooBigMessageLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
