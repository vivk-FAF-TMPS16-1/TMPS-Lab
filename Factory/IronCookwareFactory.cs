using CreationalDesignPatterns.Cookware;
using CreationalDesignPatterns.Cookware.Builder;

namespace CreationalDesignPatterns.Factory
{
    public class IronCookwareFactory : IBaseFactory
    {
        private BuilderDirector _director = new BuilderDirector();

        #region Singleton implementation

        private static IronCookwareFactory _instance;

        public static IronCookwareFactory Instance
        {
            get
            {
                if (_instance == null) 
                    _instance = new IronCookwareFactory();
                return _instance;
            }
        }

        #endregion

        private IronCookwareFactory()
        {
        }

        public ICookware Create(string type)
        {
            switch (type)
            {
                case "pot":
                    var potBuilder = new PotBuilder();
                    _director.MakeIronPot(potBuilder);
                    return potBuilder.Get();
                case "pan":
                    var panBuilder = new PanBuilder();
                    _director.MakeIronPan(panBuilder);
                    return panBuilder.Get();
                case "casserole":
                    var casseroleBuilder = new CasseroleBuilder();
                    _director.MakeIronCasserole(casseroleBuilder);
                    return casseroleBuilder.Get();
                default:
                    return null;
            }
        }
    }
}