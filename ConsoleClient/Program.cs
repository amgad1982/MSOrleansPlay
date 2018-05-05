using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Grains.GrainsContracts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Orleans;
using Orleans.Configuration;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(async () =>
            {
                await MainAsync(args);
            }).GetAwaiter().GetResult();
        }

        static async Task MainAsync(string[] args)
        {
           
            var builder = new ClientBuilder()
                // Use localhost clustering for a single local silo
                .UseLocalhostClustering()
                // Configure ClusterId and ServiceId
                .Configure<ClusterOptions>(options =>
                {
                    options.ClusterId = "dev";
                    options.ServiceId = "c1";
                })
                .ConfigureLogging(logging => logging.AddConsole());
            var client = builder.Build();
            await client.Connect();
            
            var list=await client.GetGrain<IBoardGrain>(Guid.Empty).GetAllBoards();
            foreach (var board in list)
            {
                Console.WriteLine(board.BoardHeader);
            }

            Console.ReadKey();
        }
    }
}
