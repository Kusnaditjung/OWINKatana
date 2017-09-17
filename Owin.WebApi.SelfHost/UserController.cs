using System.Web.Http;

namespace Owin.WebApi.SelfHosting
{
	[RoutePrefix("User")]
	public class UserController : ApiController
	{
		[Route("{identifier}")]		
		[HttpGet]
		public IHttpActionResult GetUser(string identifier)
		{
			if (identifier == "1234")
			{
				return Json(new 
				{
					Givenname = "Peter",
					Surname = "Smith",
					Age = 45
				});
			}

			return NotFound();
		}
	}	
}

