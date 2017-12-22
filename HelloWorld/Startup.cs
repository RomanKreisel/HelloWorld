using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;

namespace HelloWorld
{
    public class Startup
    {
        public Startup(IHostingEnvironment hostingEnvironment){
        }

        public void Configure(IApplicationBuilder applicationBuilder, IHostingEnvironment hostingEnvironment, ILoggerFactory loggerFactory)
        {
            applicationBuilder.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World");
            });
        }
    }
}