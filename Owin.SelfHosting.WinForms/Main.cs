using System;
using System.Windows.Forms;
using Microsoft.Owin.Hosting;

namespace Owin.SelfHosting.WinForms
{
	public partial class Main : Form
	{
		private IDisposable _server;

		public Main()
		{
			InitializeComponent();
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if (btnStart.Text == "Start")
			{
				txtLog.Clear();
				System.Console.SetOut(new ControlWriter(txtLog));

				string hostUrl = "http://localhost:9000/winforms";
				_server = WebApp.Start<Startup>("");
				System.Console.WriteLine(string.Format("Start listening at {0} ...", hostUrl));
				btnStart.Text = "Stop";
			}
			else
			{
				_server.Dispose();
				btnStart.Text = "Start";
				txtLog.Clear();
			}
		}
	}
}
