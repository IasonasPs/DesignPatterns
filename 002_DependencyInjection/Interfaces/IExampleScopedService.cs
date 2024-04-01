using Microsoft.Extensions.DependencyInjection;

namespace _002_DependencyInjection.Interfaces
{
    internal interface IExampleScopedService : IReportServiceLifetime
    {
        ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Scoped;
    }
}
