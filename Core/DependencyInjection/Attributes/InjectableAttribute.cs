using System;

namespace DeathlyEnterprises.Core.DependencyInjection
{
    [AttributeUsage(AttributeTargets.Interface)]
    public class InjectableAttribute : Attribute
    {
        public InjectableAttribute(InjectableLifestyle injectableLifestyle)
        {
            Lifestyle = injectableLifestyle;
        }

        public InjectableLifestyle Lifestyle { get; }
    }

    public enum InjectableLifestyle
    {
        Singleton = 1,
        Transient = 2,
        Scoped = 3
    }
}