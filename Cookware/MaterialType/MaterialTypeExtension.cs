namespace CreationalDesignPatterns.Cookware
{
    public static class MaterialTypeExtension
    {
        public static string ToString(this MaterialType type)
        {
            return type switch
            {
                MaterialType.Glass => "Glass",
                MaterialType.Iron => "Iron",
                MaterialType.Steel => "Steel",
                _ => "WARNING: IMPLEMENT ME"
            };
        }
    }
}