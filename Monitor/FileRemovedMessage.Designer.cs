
namespace UI
{
	partial class FileRemovedMessage
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(578, 99);
			this.label1.TabIndex = 0;
			this.label1.Text = "Мы не знаем, как это могло случиться, так что выбор за вами. Вы можете продолжить" +
			" следить за файлом в новом месте или восстановить его из резервной копии. Более " +
			"подробная информация указана ниже.";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 183);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(155, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Старый путь к файлу";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 207);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(155, 24);
			this.label3.TabIndex = 2;
			this.label3.Text = "Новый путь к файлу";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 231);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(155, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Последняя копия создана";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(186, 183);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(404, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "label5";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(186, 207);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(404, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "label6";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(186, 231);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(404, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "label7";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(414, 257);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(176, 42);
			this.button1.TabIndex = 7;
			this.button1.Text = "Восстановить файл";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(229, 257);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(179, 42);
			this.button2.TabIndex = 8;
			this.button2.Text = "Всё в порядке, следить за новым файлом";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// FileRemovedMessage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(602, 311);
			this.ControlBox = false;
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FileRemovedMessage";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Ваш важный файл был переименован!";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.FileRemovedMessageLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
