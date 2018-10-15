
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
	/// <summary>
	/// Description of FileRemovedMessage.
	/// </summary>
	public partial class FileRemovedMessage : Form
	{
		public string ActionSelected = "";
		public string d1;
		public string d2;
		public string d3;
		public FileRemovedMessage()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			ActionSelected = "restore";
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			ActionSelected = "reset";
		}
		
		void FileRemovedMessageLoad(object sender, EventArgs e)
		{
			label5.Text = d1;
			label6.Text = d2;
			label7.Text = d3;
		}
	}
}
