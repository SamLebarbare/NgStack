using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using Nancy.Conventions;

namespace NancyApp
{
	public class CustomBootstrapper : DefaultNancyBootstrapper
	{


		protected override void ConfigureConventions(NancyConventions conventions)
		{
			base.ConfigureConventions (conventions);

			conventions.StaticContentsConventions.Add (
			
				 StaticContentConventionBuilder.AddDirectory("/assets/js", @"/assets/js")

			);

			conventions.StaticContentsConventions.Add (

				 StaticContentConventionBuilder.AddDirectory ("/assets/css", @"/assets/css")

			);

			conventions.StaticContentsConventions.Add (

				 StaticContentConventionBuilder.AddDirectory ("/assets/ico", @"/assets/ico")

			);
		}
	}
}