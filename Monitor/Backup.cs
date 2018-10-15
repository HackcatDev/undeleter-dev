using System.IO;
using System.Collections.Generic;
using System.Text;
using System;
using Newtonsoft.Json;

namespace Monitor
{
	public class Backup
	{
		public Backup()
		{
		}
		
		public static long CreateBackup(String file, String reason = "CHANGED")
		{
			long id = DateTime.Now.ToBinary();
			while (File.Exists(Settings.BackupPath + id.ToString())) { id++; }
			FileStream fs = new FileStream(file, FileMode.OpenOrCreate);
			BackupData bd = new BackupData();
			bd.DateTimeCreated = DateTime.Now;
			bd.ID = id;
			if (fs.Length > Settings.MaxFileSize)
			{
				return Constants.ERR_FILE_TOO_BIG;
			}
			fs.Close();
			File.Copy(file, Settings.BackupPath + id.ToString() + ".hbf");
			bd.Length = new FileInfo(Settings.BackupPath + id.ToString() + ".hbf").Length;
			bd.OriginalFullName = file;
			bd.OriginalName = new FileInfo(file).Name;
			bd.md5 = Functions.FileMD5(file);
			File.WriteAllText(Settings.MetadataPath + id.ToString() + ".hbf-meta", JsonConvert.SerializeObject(bd));
			GC.Collect();
			Functions.LogAction("Backup (" + id.ToString() + ") created successfully!", "BACKUP");
			return id;
		}
		public static int DeleteBackup(long id)
		{
			File.Delete(Settings.MetadataPath + id.ToString() + ".hbf-meta");
			File.Delete(Settings.BackupPath + id.ToString() + ".hbf");
			Functions.LogAction("Backup #" + id.ToString() + " successfully removed!", "BACKUP");
			return Constants.MSG_OK;
		}
		public static int RestoreBackup(long id, String dest)
		{
			if (File.Exists(Settings.MetadataPath + id.ToString() + ".hbf-meta"))
			{
				BackupData bd = JsonConvert.DeserializeObject<BackupData>(File.ReadAllText(Settings.MetadataPath + id.ToString() + ".hbf-meta"));
				File.Copy(Settings.BackupPath + id.ToString() + ".hbf", dest);
				Functions.LogAction("Backup (" + id.ToString() + ") restored successfully!", "BACKUP");
				if (Functions.FileMD5(dest) == bd.md5)
				{
					if (new FileInfo(dest).Length == bd.Length)
					{
						return Constants.MSG_OK;
					}
					return Constants.ERR_BAD_LENGTH;
				} else { return Constants.ERR_BAD_CHECSUM; }
			} else
			{
				return Constants.ERR_FILE_NOT_FOUND;
			}
		}
		
		public static List<BackupData> GetFileBackups(String path)
		{
			List<BackupData> result = new List<BackupData>();
			foreach (var f in Directory.EnumerateFiles(Settings.MetadataPath))
			{
				FileInfo fi = new FileInfo(f);
				if (!fi.Extension.Contains("hbf-meta")) continue;
				BackupData bd = JsonConvert.DeserializeObject<BackupData>(File.ReadAllText(f));
				if (bd.OriginalFullName == path) result.Add(bd);
			}
			return result;
		}
		
		public static BackupData GetLastBackup(String path)
		{
			long max = 0;
			BackupData bd = new BackupData();
			foreach (var b in GetFileBackups(path))
			{
				if (b.DateTimeCreated.ToBinary() > max)
				{
					max = b.DateTimeCreated.ToBinary();
					bd = b;
				}
			}
			return bd;
		}
	}
}
