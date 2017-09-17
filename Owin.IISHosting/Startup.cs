namespace Owin.IISHosting
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
