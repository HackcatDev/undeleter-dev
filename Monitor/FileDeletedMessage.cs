
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
	/// <summary>
	/// Description of FileDeletedMessage.
	/// </summary>
	public partial class FileDeletedMessage : Form
	{
		public FileDeletedMessage()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public string act = "";
		void Button2Click(object sender, EventArgs e)
		{
			act = "delete";
		}
		public String d1;
		public String d2;
		public String d3;
		void Button1Click(object sender, EventArgs e)
		{
			act = "restore";
		}
		
		void FileDeletedMessageLoad(object sender, EventArgs e)
		{
			label5.Text = d1;
			label6.Text = d2;
			label7.Text = d3;
		}
	}
}
