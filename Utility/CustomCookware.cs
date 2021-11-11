using CreationalDesignPatterns.Cookware;
using CreationalDesignPatterns.Factory;
using CreationalDesignPatterns.Wrapper;

namespace CreationalDesignPatterns
{
    public class CustomCookware
    {
        private IBaseFactory _baseFactory;

        public CustomCookware(IBaseFactory baseFactory)
        {
            _baseFactory = baseFactory;
        }

        public ICookware GetCustomCookware(string type, float volume, MaterialType materialType)
        {
            IBaseFactory factory = new CustomVolume(volume, _baseFactory);
            var customCookware = factory.Create(type);
            customCookware.MaterialType = materialType;
            return customCookware;
        }
    }
}