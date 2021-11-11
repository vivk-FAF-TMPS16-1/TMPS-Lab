namespace CreationalDesignPatterns.Cookware
{
    public interface ICookware
    {
        string Name { set; }
        MaterialType MaterialType { set; }
        float Price { set; }
        float Volume { set; }
        
        string Info { get; }
    }
}