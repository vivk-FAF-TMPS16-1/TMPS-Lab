using CreationalDesignPatterns.Cookware;
using CreationalDesignPatterns.Factory;

namespace CreationalDesignPatterns.Wrapper
{
    public class CustomVolume : BaseCookwareFactoryDecorator
    {
        private float _customVolume;
        
        public CustomVolume(float customVolume, IBaseFactory baseFactory) : base(baseFactory)
        {
            _customVolume = customVolume;
        }
        
        public override ICookware Create(string type)
        {
            var cookware = base.Create(type);
            cookware.Volume = _customVolume;
            return cookware;
        }
    }
}