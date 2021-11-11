using CreationalDesignPatterns.Cookware;

namespace CreationalDesignPatterns
{
    public abstract class AdapterUtility : ICookware
    {
        protected string _name;
        protected MaterialType _materialType;
        protected float _price;
        protected float _volume;
        
        #region ICookware implementation
        
        public string Name { set => _name = value; }
        public MaterialType MaterialType { set => _materialType = value; }
        public float Price { set => _price = value; }
        public float Volume { set => _volume = value; }

        public abstract string Info { get; }

        #endregion
    }
}