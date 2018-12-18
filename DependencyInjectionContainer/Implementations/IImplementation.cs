namespace DependencyInjectionContainer.Implementations
{
    public interface IImplementation<T> where T : class
    {
        T Resolve();
    }
}