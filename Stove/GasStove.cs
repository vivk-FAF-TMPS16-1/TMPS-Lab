namespace CreationalDesignPatterns.Stove
{
    public class GasStove : IStove
    {
        #region IStove implementation
        
        public string Name { get; set; } = "Custom Gas Stove";
        public string Company { get; set; } = "Sharp";
        public float Price { get; set; } = 999f;

        public string Info =>
            "GAS STOVE:" + " " +
            "name = " + Name + ", " + 
            "company = " + Company + ", " + 
            "price = " + Price;
        
        #endregion
    }
}