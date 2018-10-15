
using System;

namespace Monitor
{
	public struct BackupData
	{
		public long ID;
		public long Length;
		public DateTime DateTimeCreated;
		public String OriginalFullName;
		public String OriginalName;
		public string md5;
		public String Reason;
	}
}
