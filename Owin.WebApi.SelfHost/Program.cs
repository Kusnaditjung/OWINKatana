using System;
using Microsoft.Owin.Hosting;
using Owin.WebApi.SelfHosting;

namespace Owin.WebApi.SelfHost
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			string hostUrl = "http://localhost:9000/webapi/selfhosting";
			using (var server = WebApp.Start<Startup>(hostUrl))
			{
				Console.WriteLine(string.Format("Start Listening at {0} ...", hostUrl));
				Console.ReadKey();
			}
		}
	}
}
