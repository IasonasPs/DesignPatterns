using Microsoft.Extensions.DependencyInjection;

namespace _002_DependencyInjection.Interfaces
{
    internal interface IExampleSingletonService : IReportServiceLifetime
    {
        ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Singleton;
    }
}
