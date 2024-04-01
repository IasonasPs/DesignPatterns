using _002_DependencyInjection.Interfaces;

namespace _002_DependencyInjection.Implementations
{
    internal sealed class ExampleScopedService : IExampleScopedService
    {
        public Guid Id { get; } = Guid.NewGuid();
    }
}
