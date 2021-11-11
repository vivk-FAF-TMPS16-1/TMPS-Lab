namespace CreationalDesignPatterns.Stove
{
    public interface IStove
    {
        string Name { set; }
        string Company { set; }
        float Price { set; }
        string Info { get; }
    }
}