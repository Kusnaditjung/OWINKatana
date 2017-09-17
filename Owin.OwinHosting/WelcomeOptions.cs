namespace Owin.OwinHosting
{ 
	internal class WelcomeOption
	{
		public string HostName { get; set; }
		public string Welcome { get; set; }

		public WelcomeOption(string hostName, string welcome)
		{
			HostName = hostName;
			Welcome = welcome;
		}
	}
}
