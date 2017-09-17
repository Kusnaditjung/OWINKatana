using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

//modified from answer to https://stackoverflow.com/questions/18726852/redirecting-console-writeline-to-textbox
namespace Owin.SelfHosting.WinForms
{
	public class ControlWriter : TextWriter
	{
		private Control textbox;
		public ControlWriter(Control textbox)
		{
			this.textbox = textbox;
		}
		
		public override void Write(string value)
		{
			if (textbox.InvokeRequired)
			{
				textbox.Invoke(new Action<char>(Write), value);
			}
			else
			{
				textbox.Text += value;
			}
		}

		public override Encoding Encoding
		{
			get { return Encoding.ASCII; }
		}
	}
}