
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
	/// <summary>
	/// Description of FileTooBigMessage.
	/// </summary>
	public partial class FileTooBigMessage : Form
	{
		public FileTooBigMessage()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public String d1;
		public String d2;
		public String d3;
		public String d4;
		
		void FileTooBigMessageLoad(object sender, EventArgs e)
		{
			label6.Text = d1;
			label7.Text = d2;
			label8.Text = d3;
			label9.Text = d4;
		}
	}
}
