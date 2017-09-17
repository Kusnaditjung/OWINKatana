using System.Web.Http;

namespace Owin.WebApi.IISHosting
{
	public class Startup
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
