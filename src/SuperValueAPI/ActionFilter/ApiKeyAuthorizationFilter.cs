
using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SuperValueAPI.ActionFilter
{
    public class ApiKeyAuthorizationAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
          System.Console.WriteLine(context.HttpContext.Request.Headers["Authorization"]);
        }
    }
}