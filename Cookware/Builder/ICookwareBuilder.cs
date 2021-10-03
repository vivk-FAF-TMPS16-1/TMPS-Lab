namespace CreationalDesignPatterns.Cookware.Builder
{
    public interface ICookwareBuilder
    {
        string Name { set; }
        MaterialType MaterialType { set; }
        float Price { set; }

        void Reset();
    }
}