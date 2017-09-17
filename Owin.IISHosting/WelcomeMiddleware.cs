using System;
using System.Threading.Tasks;
using Microsoft.Owin;

namespace Owin.IISHosting
{ 
	internal class WelcomeMiddleware : OwinMiddleware
	{
		private readonly WelcomeOption _option;

		public WelcomeMiddleware(OwinMiddleware next, WelcomeOption option) : base(next)
		{
			_option = option;
		}

		public override async Task Invoke(IOwinContext context)
		{
			System.Console.WriteLine("Http request received at " + DateTime.UtcNow.ToString());
			//await Next.Invoke(context); //For IIS Integrated pipeline, the last middleware shouldbe non passthrough
			string welcome = string.Format("I am {0}. {1}{2}", _option.HostName, _option.Welcome, Environment.NewLine);
			await context.Response.WriteAsync(welcome).ConfigureAwait(false);
		}
	}
}
