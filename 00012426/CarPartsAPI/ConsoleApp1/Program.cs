using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using sem7api.Repositories;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddSingleton<ITOrdersRepository, TOrdersRepository>()
                .BuildServiceProvider();

            var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

            var logger = serviceProvider.GetService<ILoggerFactory>()
                .CreateLogger<Program>();
            logger.LogDebug("Starting application");

            //do the actual work here
            var bar = serviceProvider.GetService<ITOrdersRepository>();
            bar.RetrieveAll();

            logger.LogDebug("All done!");





            TOrdersRepository repo = null;

            repo.RetrieveAll();

            Console.WriteLine("Hello World!");
        }
    }
}
