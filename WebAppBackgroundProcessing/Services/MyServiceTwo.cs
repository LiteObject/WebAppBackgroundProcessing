namespace WebAppBackgroundProcessing.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    using Microsoft.Extensions.Hosting;

    /// <summary>
    /// The my service two.
    /// https://docs.microsoft.com/en-us/dotnet/standard/microservices-architecture/multi-container-microservice-net-applications/background-tasks-with-ihostedservice
    /// </summary>
    public class MyServiceTwo : BackgroundService
    {
        /// <inheritdoc />
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            stoppingToken.Register(() =>
                Console.WriteLine($"{nameof(MyServiceTwo)} background task is stopping."));

            while (!stoppingToken.IsCancellationRequested)
            {
                Console.WriteLine($"{nameof(MyServiceTwo)} task doing background work.");

                // Custom op here
                await Task.Delay(5000, stoppingToken);
            }

            Console.WriteLine($"{nameof(MyServiceTwo)} background task is stopping.");
        }
    }
}
