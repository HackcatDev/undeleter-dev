using System.IO;
using System.Text;
using System.Security.Cryptography;
using System;

namespace Monitor
{
	public class Functions
	{
		public static string FileMD5(String path)
		{
			byte[] file = File.ReadAllBytes(path);
			MD5CryptoServiceProvider md5c = new MD5CryptoServiceProvider();
			byte[] hash = md5c.ComputeHash(file);
			String result = "";
			foreach (var b in hash)
			{
				result += b.ToString("X2").ToLower();
			}
			return result;
		}
		
		public static string SizeToText(long size)
		{
			string result = "";
			string[] sizes = { "Б", "КБ", "МБ", "ГБ", "ТБ" };
			double len = size;
			int order = 0;
			while (len >= 1024 && order < sizes.Length - 1) {
			    order++;
			    len = len/1024;
			}

			// Adjust the format string to your preferences. For example "{0:0.#}{1}" would
			// show a single decimal place, and no space.
			result = String.Format("{0:0.##} {1}", len, sizes[order]);
			return result;
		}
		
		public static void LogAction(String text, String module = "GENERIC")
		{
			File.AppendAllText(Settings.LogPath, "["+DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "] [" + module + "] " + text + "\r\n");
		}
	}
}
