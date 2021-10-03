namespace CreationalDesignPatterns.Cookware
{
    public interface ICookware
    {
        string Name { set; }
        MaterialType MaterialType { set; }
        float Price { set; }
        
        string Info { get; }
    }
}