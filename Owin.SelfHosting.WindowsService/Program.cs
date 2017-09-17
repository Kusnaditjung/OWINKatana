using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Owin.SelfHosting.WindowsService
{
	class Program
	{
		static void Main(string[] args)
		{
			ServiceBase[] ServicesToRun = new ServiceBase[] { new OwinService() };
			ServiceBase.Run(ServicesToRun);
		}
	}
}
