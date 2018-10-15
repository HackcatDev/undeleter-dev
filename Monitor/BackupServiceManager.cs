using System.Collections.Generic;
using System;

namespace Monitor
{
	/// <summary>
	/// Description of BackupServiceManager.
	/// </summary>
	public class BackupServiceManager
	{
		Dictionary<String,FileMonitor> monitors = new Dictionary<String,FileMonitor>();
		public BackupServiceManager()
		{
		}
		public void EnableFor(String path)
		{
			if (monitors.ContainsKey(path))
			{
                monitors[path].EnableWatching();
                return;
			}
			FileMonitor fm = new FileMonitor(path);
			fm.EnableWatching();
			monitors.Add(path,fm);
		}
		public void DisableFor(String path)
		{
			if (!monitors.ContainsKey(path))
			{
				return;
			}
			var fm = monitors[path];
			fm.DisbleWatching();
			monitors.Remove(path);
			fm = null;
			GC.Collect();
		}
		public List<FileMonitor> GetAllRunningInstances()
		{
			var a = new List<FileMonitor>();
			foreach (var ci in monitors.Values)
			{
				a.Add(ci);
			}
			return a;
		}
	}
}
