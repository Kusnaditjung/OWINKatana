using System.Web.Http;

namespace Owin.WebApi.SelfHosting
{
	internal class Startup
	{
		public void Configuration(IAppBuilder appBuilder)
		{
			var httpConfig = new HttpConfiguration();
			httpConfig.MapHttpAttributeRoutes();
			httpConfig.EnsureInitialized();

			appBuilder
				.UseWebApi(httpConfig);
		}
	}
}
