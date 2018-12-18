using System;
using System.Collections.Generic;

namespace DependencyInjectionContainer
{
    public class Config
    {
        private Dictionary<Type, List<Type>> _dependencyImplementationMap;
        
        public void Register<I, T>()
        {
            
        }
    }
}