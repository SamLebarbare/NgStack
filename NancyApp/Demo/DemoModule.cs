using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace NancyApp
{
	public class DemoModule : NancyModule
	{
		public DemoModule()
		{
			Get["/"] = parameters =>
			{
				return View["View/demo.html"];
			};
			
		}

	}
}