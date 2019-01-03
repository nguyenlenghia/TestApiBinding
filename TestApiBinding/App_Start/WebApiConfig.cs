using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace TestApiBinding
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //GlobalConfiguration.Configuration.ParameterBindingRules.Insert(0, TestApiBinding.Common.SimplePostVariableParameterBinding.HookupParameterBinding);
            GlobalConfiguration.Configuration.ParameterBindingRules.Insert(0, (des) => new Common.MultipleParameterFromBodyParameterBinding(des));
            

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
