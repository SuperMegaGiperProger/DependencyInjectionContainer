using System;
using DependencyInjectionContainer.Implementations;

namespace DependencyInjectionContainer
{
    public class Dependency<Interface, Implementation>
        where Interface : class
        where Implementation : IImplementation<Interface>
    {
        public Type ImplementationType;
        
        public IImplementation<Interface> 
    }
}