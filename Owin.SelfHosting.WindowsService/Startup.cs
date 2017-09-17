namespace Owin.SelfHosting.WindowsService
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
