using CreationalDesignPatterns.Cookware;
using CreationalDesignPatterns.Cookware.Builder;

namespace CreationalDesignPatterns.Factory
{
    public class SteelCookwareFactory : IBaseFactory
    {
        private BuilderDirector _director = new BuilderDirector();

        #region Singleton implementation

        private static SteelCookwareFactory _instance;

        public static SteelCookwareFactory Instance
        {
            get
            {
                if (_instance == null) 
                    _instance = new SteelCookwareFactory();
                return _instance;
            }
        }

        #endregion

        private SteelCookwareFactory()
        {
        }

        public ICookware Create(string type)
        {
            switch (type)
            {
                case "pot":
                    var potBuilder = new PotBuilder();
                    _director.MakeSteelPot(potBuilder);
                    return potBuilder.Get();
                case "pan":
                    var panBuilder = new PanBuilder();
                    _director.MakeSteelPan(panBuilder);
                    return panBuilder.Get();
                case "casserole":
                    var casseroleBuilder = new CasseroleBuilder();
                    _director.MakeSteelCasserole(casseroleBuilder);
                    return casseroleBuilder.Get();
                default:
                    return null;
            }
        }
    }
}