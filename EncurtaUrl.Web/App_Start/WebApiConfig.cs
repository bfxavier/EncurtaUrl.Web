using EncurtaUrl.Web.FIlters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace EncurtaUrl.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Filters.Add(new EncurtaUrlApiErrorFilter());

            // Web API routes
            config.MapHttpAttributeRoutes();
        }
    }
}
