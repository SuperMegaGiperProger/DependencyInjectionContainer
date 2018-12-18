namespace DependencyInjectionContainer.Implementations
{
    public class Singleton<T> : Base<T> where T : class
    {
        private T _instance;

        Singleton()
        {
            _instance = null;
        }

        public override T Resolve()
        {
            return _instance = _instance ?? getInstance();
        }
    }
}