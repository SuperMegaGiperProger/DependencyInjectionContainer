namespace DependencyInjectionContainer.Implementations
{
    public class Instance<T> : Base<T> where T : class
    {
        public override T Resolve()
        {
            return getInstance();
        }
    }
}