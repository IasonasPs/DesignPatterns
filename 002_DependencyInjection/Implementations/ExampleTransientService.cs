using _002_DependencyInjection.Interfaces;

namespace _002_DependencyInjection.Implementations
{
    internal sealed class ExampleTransientService : IExampleTransientService
    {
         Guid IReportServiceLifetime.Id { get;} = Guid.NewGuid();
    }
}
