using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace UrlRouting.Infrastructure
{
    public class WeekdayConstraint:IRouteConstraint
    {
        private static string[] Days = new[] {"pzt", "sal", "çar", "pers", "cum", "cmt", "paz"};
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values,
            RouteDirection routeDirection)
        {
            return Days.Contains(values[routeKey]?.ToString().ToLowerInvariant());

        }
    }
}
