using System.Timers;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace UI
{
	/// <summary>
	/// Description of MainWindow.
	/// </summary>
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
            CheckForIllegalCrossThreadCalls = false;
			timer = new System.Timers.Timer();
			timer.Elapsed += new ElapsedEventHandler(delegate
			{
				label6.Text = Directory.GetFiles(Monitor.Settings.BackupPath).Length.ToString();
				label9.Text = Monitor.Functions.SizeToText(Monitor.Settings.MaxBackupSize);
				uptime_sec++;
				TimeSpan ts = TimeSpan.FromSeconds(uptime_sec);
				label8.Text = ts.ToString(@"dd\:hh\:mm\:ss");
				long bks = 0;
				foreach (var f in Directory.GetFiles(Monitor.Settings.BackupPath))
				{
					FileInfo fi = new FileInfo(f);
					bks += fi.Length;
				}
				label7.Text = Monitor.Functions.SizeToText(bks);
				if (!Working) uptime_sec = -1;
			                                         });
			timer.AutoReset = true;
			timer.Interval = 1000;
			timer.Start();
			ni.Click += delegate { this.Show();
								   ni.Visible = false; };
			ni.Icon = new Icon("tray.ico");
			ni.ContextMenu = new ContextMenu(new MenuItem[] {
			                                 	new MenuItem("Показать окно", delegate { this.Show(); ni.Visible = false;}),
			                                 	new MenuItem("Выход", delegate { ВыходToolStripMenuItemClick(null,null); })
			                                 });
		}
		NotifyIcon ni = new NotifyIcon();
		
		void ОПрограммеToolStripMenuItemClick(object sender, EventArgs e)
		{
			AboutBox ab = new AboutBox();
			ab.ShowDialog();
		}
		void ExitProg(bool hide, bool force)
		{
			if (hide)
			{
				this.Hide();
				ni.Visible = true;
			}
			else
			{
				System.Diagnostics.Process.GetCurrentProcess().Kill();
			}
		}

        System.Timers.Timer timer = new System.Timers.Timer(1000);
        public int uptime_sec = -1;
        public int copies = 0;
        public long freespace = 0;
        public long usedspace = 0;

		void ВыходToolStripMenuItemClick(object sender, EventArgs e)
		{
			var a = MessageBox.Show("Вы действительно хотите выйти из Undeleter? Нажмите Да, чтобы выйти, нажмите Нет, чтобы скрыть окно программы, или Отмена, для отмены закрытия", "Вопрос", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
			if (a == DialogResult.Yes)
			{
				ExitProg(false, true);
			}
			if (a == DialogResult.No)
			{
				ExitProg(true, true);
			}
		}
		
		void MainWindowFormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			ВыходToolStripMenuItemClick(null,null);
		}
		
		public static bool Working = false;
		Monitor.BackupServiceManager bsm = new Monitor.BackupServiceManager();
		public void EnableService()
		{
			try {
				foreach (var ci in listBox1.Items)
				{
					bsm.EnableFor(ci.ToString());
				}
				Working = true;
				label1.Text = "Работает";
				button1.Text = "Выключить";
			} catch (Exception exc) {
                Monitor.Functions.LogAction("Error starting service: " + exc.StackTrace + "\r\n", "FM");
                MessageBox.Show("Не удалось запустить сервис по причине неизвестной ошибки.\r\n" + exc.Message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
        void DisableService()
        {
        	foreach (var ci in bsm.GetAllRunningInstances())
        	{
        		ci.DisbleWatching();
        	}
        	label1.Text = "Выключен";
        	button1.Text = "Включить";
        	Working = false;
        }

		void Button1Click(object sender, EventArgs e)
		{
			if (!Working)
			{
				EnableService();
			} else
			{
				if (Working) DisableService();
			}
            
		}
		
		void КопииToolStripMenuItemClick(object sender, EventArgs e)
		{
			new BackupViewer().ShowDialog();
		}
		
		void СкрытьОкноToolStripMenuItemClick(object sender, EventArgs e)
		{
			ExitProg(true,true);
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			if (!File.Exists(textBox1.Text))
			{
				MessageBox.Show("Файл, который вы выбрали, не существует. Повторите попытку.","Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			listBox1.Items.Add(textBox1.Text);
			bsm.EnableFor(textBox1.Text);
			textBox1.Text = "";
			MessageBox.Show("Контроль успешно включён!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex < 0) return;
			if (MessageBox.Show("Вы действительно хотите отключить слежку за этим файлом? Существующие копии не будут удалены.","Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				String path = listBox1.Items[listBox1.SelectedIndex].ToString();
				bsm.DisableFor(path);
				listBox1.Items.RemoveAt(listBox1.SelectedIndex);
			}
		}
		bool flag_edt = false;
		void Button4Click(object sender, EventArgs e)
		{
			if (flag_edt == false)
			{
				if (listBox1.SelectedIndex < 0) return;
				textBox1.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
				listBox1.Enabled = false;
				flag_edt = true;
				MessageBox.Show("Когда редактирование будет закончено, нажмите эту кнопку ещё раз","Инструкция", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} else
			{
				if (!File.Exists(textBox1.Text))
				{
					MessageBox.Show("Файл, который вы выбрали, не существует. Повторите попытку.","Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				int pth = listBox1.SelectedIndex;
				String p = listBox1.Items[pth].ToString();
				bsm.DisableFor(p);
				listBox1.Items.RemoveAt(pth);
				listBox1.Items.Add(textBox1.Text);
				bsm.EnableFor(textBox1.Text);
				textBox1.Text = "";
				listBox1.Enabled = true;
				flag_edt = false;
				MessageBox.Show("Запись успешно обновлена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
