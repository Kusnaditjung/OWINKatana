using Microsoft.Owin.Hosting;

namespace Owin.SelfHosting.Console
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			string hostUrl = "http://localhost:9000/console";
			using (WebApp.Start<Startup>(""))
			{
				System.Console.WriteLine(string.Format("Start Listening at {0} ...", hostUrl));
				System.Console.ReadKey();
			}
		}
	}
}
