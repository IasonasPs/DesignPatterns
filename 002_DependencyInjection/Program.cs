using _002_DependencyInjection.Implementations;
using _002_DependencyInjection.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Formats.Tar;
using System.Runtime.CompilerServices;

namespace _002_DependencyInjection
{
    internal class Program
    {
        public static  void Main(string[] args)
        {
            HostApplicationBuilder builder = new HostApplicationBuilder(args);

            builder.Services
                .AddTransient<IExampleTransientService,ExampleTransientService>()
                .AddScoped<IExampleScopedService,ExampleScopedService>()
                .AddSingleton<IExampleSingletonService,ExampleSingletonService>();

            builder.Services.AddTransient<ServiceLifetimeReporter>();

            using IHost host = builder.Build();

            ExemplifyServiceLifetime(host.Services,"Lifetime 1");
            Console.WriteLine("001");
            host.Run();

        }

        static void ExemplifyServiceLifetime(IServiceProvider hostProvider,string lifetime)
        {
            using IServiceScope serviceScope = hostProvider.CreateScope();
            IServiceProvider provider = serviceScope.ServiceProvider;
            ServiceLifetimeReporter logger = provider.GetRequiredService<ServiceLifetimeReporter>();

            logger.ReportServiceLifetimeDetails(
        $"{lifetime}: Call 1 to provider.GetRequiredService<ServiceLifetimeReporter>()");

            Console.WriteLine(".. _ ..");
        }
    }


}
