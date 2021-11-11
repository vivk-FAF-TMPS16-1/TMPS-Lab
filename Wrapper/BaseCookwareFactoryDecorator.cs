using CreationalDesignPatterns.Cookware;
using CreationalDesignPatterns.Factory;

namespace CreationalDesignPatterns.Wrapper
{
    public class BaseCookwareFactoryDecorator : IBaseFactory
    {
        protected IBaseFactory _wrapper;

        public BaseCookwareFactoryDecorator(IBaseFactory baseFactory)
        {
            _wrapper = baseFactory;
        }

        public virtual ICookware Create(string type)
        {
            return _wrapper.Create(type);
        }
    }
}