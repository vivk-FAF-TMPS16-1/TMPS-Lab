using CreationalDesignPatterns.Cookware;
using CreationalDesignPatterns.Cookware.Builder;

namespace CreationalDesignPatterns
{
    public class BuilderDirector
    {
        public ICookwareBuilder MakeIronPan(PanBuilder builder)
        {
            builder.Reset();
            builder.Name = "Kelomat";
            builder.MaterialType = MaterialType.Iron;
            builder.Price = 100;

            return builder;
        }
        
        public ICookwareBuilder MakeIronPot(PotBuilder builder)
        {
            builder.Reset();
            builder.Name = "Stoneline";
            builder.MaterialType = MaterialType.Iron;
            builder.Price = 250;

            return builder;
        }
        
        public ICookwareBuilder MakeIronCasserole(CasseroleBuilder builder)
        {
            builder.Reset();
            builder.Name = "Kmart";
            builder.MaterialType = MaterialType.Iron;
            builder.Price = 200;

            return builder;
        } 
        
        public ICookwareBuilder MakeSteelPan(PanBuilder builder)
        {
            builder.Reset();
            builder.Name = "John Lewis";
            builder.MaterialType = MaterialType.Steel;
            builder.Price = 300;

            return builder;
        }
        
        public ICookwareBuilder MakeSteelPot(PotBuilder builder)
        {
            builder.Reset();
            builder.Name = "Anolon";
            builder.MaterialType = MaterialType.Steel;
            builder.Price = 350;

            return builder;
        }
        
        public ICookwareBuilder MakeSteelCasserole(CasseroleBuilder builder)
        {
            builder.Reset();
            builder.Name = "Calphalon";
            builder.MaterialType = MaterialType.Steel;
            builder.Price = 400;

            return builder;
        }

        public ICookwareBuilder MakeGlassPan(PanBuilder builder)
        {
            builder.Reset();
            builder.Name = "Calphalon";
            builder.MaterialType = MaterialType.Glass;
            builder.Price = 500;

            return builder;
        }

        public ICookwareBuilder MakeGlassPot(PotBuilder builder)
        {
            builder.Reset();
            builder.Name = "Circulon";
            builder.MaterialType = MaterialType.Glass;
            builder.Price = 550;

            return builder;
        }
        
        public ICookwareBuilder MakeGlassCasserole(CasseroleBuilder builder)
        {
            builder.Reset();
            builder.Name = "Farberware";
            builder.MaterialType = MaterialType.Glass;
            builder.Price = 650;

            return builder;
        }
    }
}