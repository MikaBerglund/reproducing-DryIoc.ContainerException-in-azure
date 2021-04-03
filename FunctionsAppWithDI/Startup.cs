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
                    var config = sp.GetRequiredService<IConfiguration>();
                    return config.GetSection("myapp").Get<AppRootSection>();
                })
                .AddSingleton(sp =>
                {
                    var root = sp.GetRequiredService<AppRootSection>();
                    return root.Application;
                })
                .AddSingleton(sp =>
                {
                    var root = sp.GetRequiredService<AppRootSection>();
                    return root.Data;
                })
                .AddSingleton<DataService>()
                .AddSingleton<GraphClient>();
                ;
        }
    }
}
