
using System;

namespace Monitor
{
	public static class Settings
	{
		public static String BackupPath 	= "backups/";
		public static String MetadataPath 	= "backup-meta/";
		public static bool   Encrypt		= false;
		public static int    MaxFileSize 	= 10485760; //10MB
		public static byte[] Key 			= null;
		public static byte[] IV  			= null;
		public static String LogPath        = "Undeleter.log";
		public static int    MaxBackupSize  = 104857600; //100MB
	}
}
