
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
	/// <summary>
	/// Description of AboutBox.
	/// </summary>
	public partial class AboutBox : Form
	{
		public AboutBox()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label8Click(object sender, EventArgs e)
		{
			
		}
		
		void AboutBoxLoad(object sender, EventArgs e)
		{
			label5.Text = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileVersionInfo.FileVersion;
			label6.Text = new System.IO.FileInfo(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName).CreationTime.ToShortDateString();
		}
	}
}
