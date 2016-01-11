using DeathlyEnterprises.Core.Attributes;

namespace DeathlyEnterprises.Core.DependencyInjection
{
    [Injectable(InjectableLifestyle.Singleton)]
    public interface IContainer
    {
        TContract GetInstance<TContract>();
    }
}