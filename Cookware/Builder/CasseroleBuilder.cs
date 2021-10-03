namespace CreationalDesignPatterns.Cookware.Builder
{
    public class CasseroleBuilder : ICookwareBuilder
    {
        private Casserole _cookware;

        public CasseroleBuilder()
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
            _cookware = new Casserole();
        }

        #endregion

        public Casserole Get()
        {
            var cookware = _cookware;
            Reset();

            return cookware;
        }
    }
}