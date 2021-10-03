using CreationalDesignPatterns.Cookware;
using CreationalDesignPatterns.Cookware.Builder;

namespace CreationalDesignPatterns.Factory
{
    public class GlassCookwareFactory : IBaseFactory
    {
        private BuilderDirector _director = new BuilderDirector();
        
        #region Singleton implementation

        private static GlassCookwareFactory _instance;

        public static GlassCookwareFactory Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GlassCookwareFactory();
                return _instance;
            }
        }

        #endregion

        private GlassCookwareFactory() { }
        
        public ICookware Create(string type)
        {
            switch (type)
            {
                case "pot":
                    var potBuilder = new PotBuilder();
                    _director.MakeGlassPot(potBuilder);
                    return potBuilder.Get();
                case "pan":
                    var panBuilder = new PanBuilder();
                    _director.MakeGlassPan(panBuilder);
                    return panBuilder.Get();
                case "casserole":
                    var casseroleBuilder = new CasseroleBuilder();
                    _director.MakeGlassCasserole(casseroleBuilder);
                    return casseroleBuilder.Get();
                default:
                    return null;
            }
        }
    }
}