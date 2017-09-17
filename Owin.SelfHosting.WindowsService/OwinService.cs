using System;
using System.ServiceProcess;
using Microsoft.Owin.Hosting;

namespace Owin.SelfHosting.WindowsService
{
	partial class OwinService : ServiceBase
	{
		private IDisposable _server;
		public OwinService()
		{
			InitializeComponent();			
		}

		protected override void OnStart(string[] args)
		{
			string hostUrl = "http://localhost:9000/windowsservice";
			_server = WebApp.Start<Startup>(hostUrl);
		}

		protected override void OnStop()
		{
			_server.Dispose();
		}
	}
}
