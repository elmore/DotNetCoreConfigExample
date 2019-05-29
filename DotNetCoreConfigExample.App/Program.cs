using DotNetCoreConfigExample.Module;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace DotNetCoreConfigExample.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IModuleRepository, ModuleRepository>()
                .AddSingleton<IModuleService, ModuleService>()
                .BuildServiceProvider();

            var host = new HostBuilder()
                .Build();

            host.Run();

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
