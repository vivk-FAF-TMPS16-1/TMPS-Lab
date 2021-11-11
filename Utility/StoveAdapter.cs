using CreationalDesignPatterns.Cookware;
using CreationalDesignPatterns.Stove;

namespace CreationalDesignPatterns
{
    public class StoveAdapter : AdapterUtility
    {
        private IStove _stove;

        public StoveAdapter(IStove stove)
        {
            _stove = stove;
        }
        
        public override string Info => _stove.Info;
    }
}