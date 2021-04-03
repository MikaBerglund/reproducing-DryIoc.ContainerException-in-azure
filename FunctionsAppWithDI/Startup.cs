using FunctionsAppWithDI;
using FunctionsAppWithDI.Configuration;
using FunctionsAppWithDI.Services;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

[assembly: WebJobsStartup(typeof(Startup))]

namespace FunctionsAppWithDI
{
    public class Startup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            builder.Services
                .AddSingleton(sp =>
                {
                    var options = new ApplicationOptions();
                    sp.GetRequiredService<IConfiguration>()
                        .GetSection("myapp:application")
                        .Bind(options);
                    return options;
                })
                .AddSingleton(sp =>
                {
                    var options = new DatabaseOptions();
                    sp.GetRequiredService<IConfiguration>()
                        .GetSection("myapp:data")
                        .Bind(options);
                    return options;
                })
                .AddSingleton<DataService>()
                .AddSingleton<GraphClient>();
                ;
        }
    }
}
