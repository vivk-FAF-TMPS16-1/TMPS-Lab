namespace CreationalDesignPatterns.Cookware
{
    public class Pan : ICookware
    {
        private string _name;
        private MaterialType _materialType;
        private float _price;
        private float _volume = 2;
        
        #region ICookware implementation
        
        public string Name { set => _name = value; }
        public MaterialType MaterialType { set => _materialType = value; }
        public float Price { set => _price = value; }
        public float Volume { set => _volume = value; }

        public string Info =>
            "Pan:" + " " +
            "name = " + _name + ", " + 
            "material type = " + _materialType + ", " + 
            "price = " + _price + ", " + 
            "volume = " + _volume;

        #endregion
    }
}