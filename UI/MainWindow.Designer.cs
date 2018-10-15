
namespace UI
{
	partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.undeleterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скрытьОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.какПользоватьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undeleterToolStripMenuItem,
            this.копииToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // undeleterToolStripMenuItem
            // 
            this.undeleterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.скрытьОкноToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.undeleterToolStripMenuItem.Name = "undeleterToolStripMenuItem";
            this.undeleterToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.undeleterToolStripMenuItem.Text = "Undeleter";
            // 
            // скрытьОкноToolStripMenuItem
            // 
            this.скрытьОкноToolStripMenuItem.Name = "скрытьОкноToolStripMenuItem";
            this.скрытьОкноToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.скрытьОкноToolStripMenuItem.Text = "Скрыть окно";
            this.скрытьОкноToolStripMenuItem.Click += new System.EventHandler(this.СкрытьОкноToolStripMenuItemClick);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItemClick);
            // 
            // копииToolStripMenuItem
            // 
            this.копииToolStripMenuItem.Name = "копииToolStripMenuItem";
            this.копииToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.копииToolStripMenuItem.Text = "Копии";
            this.копииToolStripMenuItem.Click += new System.EventHandler(this.КопииToolStripMenuItemClick);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.какПользоватьсяToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе...";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.ОПрограммеToolStripMenuItemClick);
            // 
            // какПользоватьсяToolStripMenuItem
            // 
            this.какПользоватьсяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yToolStripMenuItem});
            this.какПользоватьсяToolStripMenuItem.Name = "какПользоватьсяToolStripMenuItem";
            this.какПользоватьсяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.какПользоватьсяToolStripMenuItem.Text = "Как пользоваться";
            // 
            // yToolStripMenuItem
            // 
            this.yToolStripMenuItem.Name = "yToolStripMenuItem";
            this.yToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yToolStripMenuItem.Text = "Никак :)";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(210, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выключен";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(222, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Включить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество копий";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Занято места";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(375, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Время работы";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(375, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Всего места";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(544, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Память...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(116, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(116, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(464, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "00:00:00:00";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(464, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "0";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "D:\\test1.txt",
            "D:\\test.rar"});
            this.listBox1.Location = new System.Drawing.Point(19, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(257, 238);
            this.listBox1.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(633, 326);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(625, 300);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Состояние";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(625, 300);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Файлы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(285, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(337, 54);
            this.label12.TabIndex = 20;
            this.label12.Text = "Тут можно настроить контроль за файлами, например добавить новый файл, изменить с" +
    "тарую запись или удалить ошибочно дбавленный файл.";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(485, 82);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "Выбрать файл...";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 20);
            this.textBox1.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(282, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 17;
            this.label11.Text = "Путь";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(526, 40);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(414, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Изменить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(282, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3Click);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(19, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(244, 23);
            this.label10.TabIndex = 13;
            this.label10.Text = "За этими файлами установлен контроль";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 365);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Undeleter by Hackcat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindowFormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.ToolStripMenuItem yToolStripMenuItem;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem какПользоватьсяToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem копииToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem скрытьОкноToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem undeleterToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
