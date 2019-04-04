using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Ocelot.Middleware;
using Ocelot.DependencyInjection;

namespace Gateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args)
                .ConfigureAppConfiguration((hostingContext, config) => {
                    // informs the app to use the ocelot.json file
                    config.AddJsonFile("ocelot.json");
                })
                .ConfigureServices(s => {
                    // enable ocelot DI
                    s.AddOcelot(); 
                })
                .Configure(app => {
                    // include ocelot middleware
                    app.UseOcelot().Wait();
                })
                .Build()
                .Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
