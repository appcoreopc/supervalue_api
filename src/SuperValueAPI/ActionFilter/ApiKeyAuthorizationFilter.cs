
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SuperValueAPI.ActionFilter
{
    public class ApiKeyAuthorizationAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
          var authorizationHeader = context.HttpContext.Request.Headers["Authorization"];
          if (String.IsNullOrWhiteSpace(authorizationHeader))
              context.Result = new UnauthorizedResult();
        }
    }
}