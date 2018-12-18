using System;

namespace DependencyInjectionContainer
{
    public abstract class Implementation<T>
    {
        public abstract T Resolve();
    }
}