// <auto-generated/>
#pragma warning disable
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;

namespace Internal.Generated.WolverineHandlers
{
    // START: GET_http_principal
    public class GET_http_principal : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _wolverineHttpOptions;

        public GET_http_principal(Wolverine.Http.WolverineHttpOptions wolverineHttpOptions) : base(wolverineHttpOptions)
        {
            _wolverineHttpOptions = wolverineHttpOptions;
        }



        public override System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var httpContextEndpoints = new WolverineWebApi.HttpContextEndpoints();
            
            // The actual HTTP request handler execution
            httpContextEndpoints.UseClaimsPrincipal(httpContext.User);

            // Wolverine automatically sets the status code to 204 for empty responses
            if (!httpContext.Response.HasStarted) httpContext.Response.StatusCode = 204;
            return System.Threading.Tasks.Task.CompletedTask;
        }

    }

    // END: GET_http_principal
    
    
}

