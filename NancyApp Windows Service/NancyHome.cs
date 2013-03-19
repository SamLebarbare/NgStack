using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;

namespace NancyApp_Windows_Service
{
	class NancyHome : Nancy.IRootPathProvider
	{
		public string GetRootPath()
		{
			return Path.GetFullPath (@"c:\Nancy");
		}
	}
}
