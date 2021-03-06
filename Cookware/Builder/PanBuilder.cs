namespace CreationalDesignPatterns.Cookware.Builder
{
    public class PanBuilder : ICookwareBuilder
    {
        private Pan _cookware;

        public PanBuilder()
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
            _cookware = new Pan();
        }

        #endregion

        public Pan Get()
        {
            var cookware = _cookware;
            Reset();

            return cookware;
        }
    }
}