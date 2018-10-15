using System.IO;
using System.Text;
using System.Security;
using System;
using System.Threading;
using System.Collections.Generic;

namespace Monitor
{
	/// <summary>
	/// Description of DirectoryWatcher.
	/// </summary>
	public class DirectoryWatcher
	{
		FileSystemWatcher watcher;
		String filepath;
		public static List<String> WatchedPaths = new List<String>();
		public static Dictionary<String,DirectoryWatcher> Watchers = new Dictionary<String,DirectoryWatcher>();
		public DirectoryWatcher(String path)
		{
			Functions.LogAction("Initializing control for directory (\"" + path + "\")...", "DIRMON");
			filepath = path;
			watcher = new FileSystemWatcher(path);
			watcher.Changed += new FileSystemEventHandler(watcher_Changed);
			watcher.Deleted += new FileSystemEventHandler(watcher_Deleted);
			watcher.Renamed += new RenamedEventHandler(watcher_Renamed);
			watcher.Error += new ErrorEventHandler(watcher_Error);
			Watchers.Add(path,this);
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
			watcher.EnableRaisingEvents = true;
		}
		
		public void DisbleWatching()
		{
			watcher.EnableRaisingEvents = false;
		}
		
		void watcher_Error(object sender, ErrorEventArgs e)
		{
			//Error in FileSystemWatcher object
			Functions.LogAction("FileMonitor error: " + e.GetException().Message, "DIRMON");
		}

		void watcher_Renamed(object sender, RenamedEventArgs e)
		{
			//File has been renamed, restart the watcher
			if (!WatchedPaths.Contains(e.OldFullPath)) return;
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
			if (!WatchedPaths.Contains(e.FullPath)) return;
			UI.FileDeletedMessage msg = new UI.FileDeletedMessage();
			msg.d1 = fname(e.FullPath);
			msg.d2 = e.FullPath;
			var a = Backup.GetLastBackup(e.FullPath).DateTimeCreated;
			msg.d3 = a.ToShortDateString() + " " + a.ToShortTimeString();
			msg.Show();
		}

		void watcher_Changed(object sender, FileSystemEventArgs e)
		{
			//File has been changed
			if (!WatchedPaths.Contains(e.FullPath)) return;
			watcher.EnableRaisingEvents = false;
			Thread.Sleep(100);
			watcher.EnableRaisingEvents = true;
			long result = Backup.CreateBackup(e.FullPath);
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
