// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
namespace CustomerKeyStore
{
    using System;
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Logging;
    public static class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            var port = Environment.GetEnvironmentVariable("PORT") ?? "5000";
            return WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .UseUrls($"http://0.0.0.0:{port}")
            .ConfigureLogging((context, logging) =>
            {
                logging.AddEventLog(eventLogSettings =>
                {
                });
            });
        }
    }
}
