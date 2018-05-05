using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Data;
using Data.Contexts;
using Data.Models;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using  Microsoft.Extensions.Logging;
using Orleans.Configuration;
using Orleans.Hosting;

namespace ConsoleHost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Task.Run(async () =>
            {
                await MainAsync(args);
            }).GetAwaiter().GetResult();
        }
        public static async Task MainAsync(string[] args)
        {
           
            try
            {
                var host = await StartSilo(args);
                Console.WriteLine("Press Enter to terminate...");
                Console.ReadLine();

                await host.StopAsync();

                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return;
            }
        }

        private static async Task<ISiloHost> StartSilo(string[] args)
        {
            var configbuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("AppSettings.json")
                .Build();

           


            var builder = new SiloHostBuilder()
                // Use localhost clustering for a single local silo
                .UseLocalhostClustering()
                // Configure ClusterId and ServiceId
                .Configure<ClusterOptions>(options =>
                {
                    options.ClusterId = "dev";
                    options.ServiceId = "c1";
                })
                // Configure connectivity
                .Configure<EndpointOptions>(options => options.AdvertisedIPAddress = IPAddress.Loopback)
                // Configure logging with any logging framework that supports Microsoft.Extensions.Logging.
                // In this particular case it logs using the Microsoft.Extensions.Logging.Console package.
                .ConfigureLogging(logging => logging.AddConsole())
                .ConfigureServices((services) => services.AddOptions()
                    .AddDbContext<AppSqlContext>(options =>
                        options.UseSqlServer(configbuilder.GetConnectionString("defaultConnection"))
                    )
                    .AddScoped(typeof(DbContext),typeof(AppSqlContext))
                .AddTransient(typeof(IRepository<Board>),typeof(BoardRepository))
                );

            var host = builder.Build();
            

            if (args.Length > 0 && args[0] == "/seed")
                DbInitilizer.Initialize((AppSqlContext)host.Services.GetService(typeof(AppSqlContext)));

            await host.StartAsync();
            return host;
        }
    }
}
