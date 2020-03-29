using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JeuxDontOnEstLeHero.Web.UI.Contraintes
{
    public class AventuresContraintes : IRouteConstraint
    {
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            try
            {
                int.Parse(values["id"].ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
