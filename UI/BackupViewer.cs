using System.IO;
using System;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace UI
{
	/// <summary>
	/// Description of BackupViewer.
	/// </summary>
	public partial class BackupViewer : Form
	{
		public BackupViewer()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		String bkp_del_msg = "Вы точно хотите удалить эту копию? Вы не сможете использовать её после этого!";
		
		void Button3Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(bkp_del_msg, "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				var row = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
				long id = Convert.ToInt64(row.Cells[0].Value);
				Monitor.Backup.DeleteBackup(id);
				dataGridView1.Rows.RemoveAt(row.Index);
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			String name = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[5].Value.ToString();
			String xt = new FileInfo(name).Extension.Replace(".","");
			saveFileDialog1.Filter = "Файлы " + xt.ToUpper() + "|*." + xt;
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				String dest = saveFileDialog1.FileName;
				var row = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
				long id = Convert.ToInt64(row.Cells[0].Value);
				long res = Monitor.Backup.RestoreBackup(id, dest);
				if (res == Monitor.Constants.MSG_OK || res == 0)
				{
					MessageBox.Show("Файл успешно восстановлен!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					switch (res)
					{
						case -12:
							MessageBox.Show("Не удалось восстановить файл корректно, так как произошла ошибка проверки контрольной суммы файла", "Ошибка");
							break;
						case -13:
							MessageBox.Show("Не удалось восстановить файл, так как копия была повреждена","Ошибка");
							break;
						default:
							MessageBox.Show("Не удалось восстановить файл по причине неизвестной ошибки","Ошибка");
							break;
					}
				}
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			String name = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[5].Value.ToString();
			String xt = new FileInfo(name).Extension.Replace(".","");
			var row = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
			long id = Convert.ToInt64(row.Cells[0].Value);
			String dest = Path.Combine(Environment.GetEnvironmentVariable("temp"), id.ToString() + "." + xt);
			File.Copy(Monitor.Settings.BackupPath + id.ToString() + ".hbf", dest, true);
			System.Diagnostics.Process.Start(dest);
		}
		
		void BackupViewerLoad(object sender, EventArgs e)
		{
			var a = Directory.EnumerateFiles(Monitor.Settings.MetadataPath);
			foreach (var file in a)
			{
				var fi = new FileInfo(file);
				if (fi.Extension.Replace(".","") == "hbf-meta")
				{
					Monitor.BackupData bd = JsonConvert.DeserializeObject<Monitor.BackupData>(File.ReadAllText(file));
					if (!File.Exists(Monitor.Settings.BackupPath + bd.ID.ToString() + ".hbf")) continue;
					List<object> obj = new List<object>();
					obj.Add(bd.ID.ToString());
					obj.Add(bd.OriginalName);
					obj.Add(bd.DateTimeCreated.ToShortDateString() + " " + bd.DateTimeCreated.ToShortTimeString());
					if (bd.Reason == "CHANGED")
					{
						obj.Add("Файл был изменён");
					} else { obj.Add(""); }
					obj.Add(Monitor.Functions.SizeToText(bd.Length));
					obj.Add(bd.OriginalFullName);
					dataGridView1.Rows.Add(obj.ToArray());
				}
			}
		}
	}
}
