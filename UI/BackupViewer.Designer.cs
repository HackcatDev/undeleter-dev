
namespace UI
{
	partial class BackupViewer
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2,
									this.Column3,
									this.Column4,
									this.Column5,
									this.Column7});
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(887, 386);
			this.dataGridView1.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "ID копии";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 140;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Файл";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 120;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Дата создания";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 110;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Причина создания";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Размер файла";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 60;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "Путь к файлу";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Width = 300;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(771, 404);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 38);
			this.button1.TabIndex = 1;
			this.button1.Text = "Восстановить копию";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(654, 404);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(111, 38);
			this.button2.TabIndex = 2;
			this.button2.Text = "Предпросмотр";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(549, 404);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(99, 38);
			this.button3.TabIndex = 3;
			this.button3.Text = "Удалить копию";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.RestoreDirectory = true;
			// 
			// BackupViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(911, 454);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BackupViewer";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Просмотр копий";
			this.Load += new System.EventHandler(this.BackupViewerLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}
