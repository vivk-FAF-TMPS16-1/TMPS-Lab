namespace CreationalDesignPatterns.Cookware.Builder
{
    public class PotBuilder : ICookwareBuilder
    {
        private Pot _cookware;

        public PotBuilder()
        {
            Reset();
        }

        #region ICookwareBuilder implementation

        public string Name
        {
            set => _cookware.Name = value;
        }

        public MaterialType MaterialType
        {
            set => _cookware.MaterialType = value;
        }

        public float Price
        {
            set => _cookware.Price = value;
        }
        
        public void Reset()
        {
            _cookware = new Pot();
        }

        #endregion

        public Pot Get()
        {
            var cookware = _cookware;
            Reset();

            return cookware;
        }
    }
}