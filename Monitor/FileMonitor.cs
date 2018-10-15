using System.IO;
using System.Text;
using System.Security;
using System;
using System.Threading;

namespace Monitor
{
	/// <summary>
	/// FileMonitor - класс, слдящий за заданным файлом и делающий бэкапы
	/// </summary>
	public class FileMonitor
	{
		FileSystemWatcher watcher;
		String filepath;
		public FileMonitor(String path)
		{
			Functions.LogAction("Initializing control for file (\"" + path + "\")...", "FILEMON");
			filepath = path;
			String hjk = dirpath(path);
			if (DirectoryWatcher.Watchers.ContainsKey(hjk))
			{
				DirectoryWatcher.Watchers[hjk].EnableWatching();
			}
			else
			{
				DirectoryWatcher dw = new DirectoryWatcher(hjk);
				dw.EnableWatching();
			}
			if (DirectoryWatcher.WatchedPaths.Contains(path)) return;
			DirectoryWatcher.WatchedPaths.Add(path);
//			watcher = new FileSystemWatcher(dirpath(path), fname(path));
//			watcher.Changed += new FileSystemEventHandler(watcher_Changed);
//			watcher.Deleted += new FileSystemEventHandler(watcher_Deleted);
//			watcher.Renamed += new RenamedEventHandler(watcher_Renamed);
//			watcher.Error += new ErrorEventHandler(watcher_Error);
		}
		
		private String dirpath(String path)
		{
			return new FileInfo(path).DirectoryName;
		}
		
		private string fname(String path)
		{
			return new FileInfo(path).Name;
		}

		public void EnableWatching()
		{
			//watcher.EnableRaisingEvents = true;
		}
		
		public void DisbleWatching()
		{
			//watcher.EnableRaisingEvents = false;
		}
		
		void watcher_Error(object sender, ErrorEventArgs e)
		{
			//Error in FileSystemWatcher object
			Functions.LogAction("FileMonitor error: " + e.GetException().Message, "FILEMON");
		}

		void watcher_Renamed(object sender, RenamedEventArgs e)
		{
			//File has been renamed, restart the watcher
			if (e.OldFullPath != filepath) return;
			UI.FileRemovedMessage msg = new UI.FileRemovedMessage();
			msg.d1 = e.OldFullPath;
			msg.d2 = e.FullPath;
			msg.d3 = Backup.GetLastBackup(e.OldFullPath).DateTimeCreated.ToShortDateString() + " " + Backup.GetLastBackup(e.OldFullPath).DateTimeCreated.ToShortTimeString();
			msg.Show();
			while (msg.ActionSelected == "") continue;
			String result = msg.ActionSelected;
			msg.Close();
			msg = null;
			if (result == "restore")
			{
				Backup.RestoreBackup(Backup.GetLastBackup(e.OldFullPath).ID, e.OldFullPath);
			}
			else
			{
				this.DisbleWatching();
				watcher.Dispose();
				watcher = new FileSystemWatcher(e.FullPath);
				this.EnableWatching();
			}
		}

		void watcher_Deleted(object sender, FileSystemEventArgs e)
		{
			//File has ben deleted
			if (e.FullPath != filepath) return;
			UI.FileDeletedMessage msg = new UI.FileDeletedMessage();
		}

		void watcher_Changed(object sender, FileSystemEventArgs e)
		{
			//File has been changed
			if (e.FullPath != filepath) return;
			watcher.EnableRaisingEvents = false;
			Thread.Sleep(100);
			watcher.EnableRaisingEvents = true;
			long result = 100;
			bool succ = false;
			result = Backup.CreateBackup(e.FullPath);
			if (result == Constants.ERR_FILE_TOO_BIG) succ = true;
			if (Math.Abs(result) > 1000) succ = true;
			if (result == Constants.ERR_FILE_TOO_BIG)
			{
				UI.FileTooBigMessage msg = new UI.FileTooBigMessage();
				msg.d1 = new FileInfo(e.FullPath).Name;
				msg.d2 = e.FullPath;
				msg.d3 = Functions.SizeToText(new FileInfo(e.FullPath).Length);
				msg.d4 = Functions.SizeToText(Settings.MaxFileSize);
				msg.ShowDialog();
			}
		}
	}
}
