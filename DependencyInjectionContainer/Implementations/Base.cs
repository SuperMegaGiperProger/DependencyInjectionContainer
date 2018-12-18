namespace DependencyInjectionContainer.Implementations
{
    public abstract class Base<T> : IImplementation<T> where T : class
    {
        public abstract T Resolve();
        
        protected T getInstance()
        {
            return null;
        }
    }
}