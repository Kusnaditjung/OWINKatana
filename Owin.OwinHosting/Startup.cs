namespace Owin.OwinHosting
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
