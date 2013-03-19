using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Nancy.Hosting.Self;

namespace NancyApp_Windows_Service
{
	public partial class Service : ServiceBase
	{
		private NancyHost host;
		public Service()
		{
			InitializeComponent ();
		}

		protected override void OnStart(string[] args)
		{
			var uri = "http://localhost:8888";
			
			host = new NancyHost (new Uri (uri));
			host.Start ();  // start hosting
		}

		protected override void OnStop()
		{
			host.Stop (); // stop hosting
		}
	}
}
