namespace CreationalDesignPatterns.Stove
{
    public class ElectroStove : IStove
    {
        #region IStove implementation
        
        public string Name { get; set; } = "Custom Electro Stove";
        public string Company { get; set; } = "Samsung";
        public float Price { get; set; } = 1999f;

        public string Info =>
            "ELECTRO STOVE:" + " " +
            "name = " + Name + ", " + 
            "company = " + Company + ", " + 
            "price = " + Price;
        
        #endregion
    }
}