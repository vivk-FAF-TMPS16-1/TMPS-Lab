namespace CreationalDesignPatterns.Stove
{
    public class SteamStove : IStove
    {
        #region IStove implementation
        
        public string Name { get; set; } = "Custom Steam Stove";
        public string Company { get; set; } = "IDK";
        public float Price { get; set; } = 9999f;

        public string Info =>
            "STEAM STOVE:" + " " +
            "name = " + Name + ", " + 
            "company = " + Company + ", " + 
            "price = " + Price;
        
        #endregion
    }
}