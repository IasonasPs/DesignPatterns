
using Microsoft.Extensions.DependencyInjection;

namespace _002_DependencyInjection.Interfaces
{
    internal interface IExampleTransientService : IReportServiceLifetime
    {
        ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Transient;
    }
}
