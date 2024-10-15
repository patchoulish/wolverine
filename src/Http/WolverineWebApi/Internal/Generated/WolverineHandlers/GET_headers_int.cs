// <auto-generated/>
#pragma warning disable
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;

namespace Internal.Generated.WolverineHandlers
{
    // START: GET_headers_int
    public class GET_headers_int : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _wolverineHttpOptions;

        public GET_headers_int(Wolverine.Http.WolverineHttpOptions wolverineHttpOptions) : base(wolverineHttpOptions)
        {
            _wolverineHttpOptions = wolverineHttpOptions;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            int number = default;
            int.TryParse(ReadSingleHeaderValue(httpContext, "x-wolverine"), out number);
            // Retrieve header value from the request
            var day = ReadSingleHeaderValue(httpContext, "x-day");
            WolverineWebApi.HeaderUsingEndpoint.Before(day);
            var headerUsingEndpoint = new WolverineWebApi.HeaderUsingEndpoint();
            
            // The actual HTTP request handler execution
            var result_of_Get = headerUsingEndpoint.Get(number);

            await WriteString(httpContext, result_of_Get);
        }

    }

    // END: GET_headers_int
    
    
}

