namespace Owin.SelfHosting.WinForms
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
