namespace Owin.SelfHosting.Console
{
	internal class Startup
	{
		public void Configuration(IAppBuilder appBuilder)
		{
			appBuilder
				.UseWelcome();
		}
	}
}
