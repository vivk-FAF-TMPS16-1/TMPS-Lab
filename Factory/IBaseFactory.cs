using CreationalDesignPatterns.Cookware;

namespace CreationalDesignPatterns.Factory
{
    public interface IBaseFactory
    {
        ICookware Create(string type);
    }
}