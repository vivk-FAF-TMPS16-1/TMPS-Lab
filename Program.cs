using System;
using CreationalDesignPatterns.Cookware;
using CreationalDesignPatterns.Factory;
using CreationalDesignPatterns.Stove;

namespace CreationalDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IBaseFactory glassFactory = GlassCookwareFactory.Instance;
            var glassPan = glassFactory.Create("pan");
            var glassPot = glassFactory.Create("pot");
            var glassCasserole = glassFactory.Create("casserole");
            Console.WriteLine("Glass Factory:");
            Console.WriteLine(glassPan.Info);
            Console.WriteLine(glassPot.Info); 
            Console.WriteLine(glassCasserole.Info); 
            Console.WriteLine();
            
            IBaseFactory steelFactory = SteelCookwareFactory.Instance;;
            var steelPan = steelFactory.Create("pan");
            var steelPot = steelFactory.Create("pot");
            var steelCasserole = steelFactory.Create("casserole");
            Console.WriteLine("Steel Factory:");
            Console.WriteLine(steelPan.Info);
            Console.WriteLine(steelPot.Info); 
            Console.WriteLine(steelCasserole.Info); 
            Console.WriteLine();

            IBaseFactory ironFactory = IronCookwareFactory.Instance;
            var ironPan = ironFactory.Create("pan");
            var ironPot = ironFactory.Create("pot");
            var ironCasserole = ironFactory.Create("casserole");
            Console.WriteLine("Iron Factory:");
            Console.WriteLine(ironPan.Info);
            Console.WriteLine(ironPot.Info); 
            Console.WriteLine(ironCasserole.Info);  
            Console.WriteLine();
            
            IStove steamStove = new SteamStove();
            IStove electroStove = new ElectroStove();
            IStove gasStove = new GasStove();

            var steamStoveAdapter = new StoveAdapter(steamStove);
            var electroStoveAdapter = new StoveAdapter(electroStove);
            var gasStoveAdapter = new StoveAdapter(gasStove);

            var kitchen = Kitchen.Instance;
            var cookwares = new ICookware[]
            {
                steamStoveAdapter,
                electroStoveAdapter,
                gasStoveAdapter,
                glassPan,
                glassPot,
                glassCasserole
            };
            kitchen.Present(cookwares);
            Console.WriteLine();

            var customCookware = new CustomCookware(glassFactory);
            var customPan = customCookware.GetCustomCookware("pan", 2, MaterialType.Glass);
            var customPot = customCookware.GetCustomCookware("pot", 3, MaterialType.Iron);
            var customCasserole = customCookware.GetCustomCookware("casserole", 1, MaterialType.Steel);
            Console.WriteLine(customPan.Info);
            Console.WriteLine(customPot.Info);
            Console.WriteLine(customCasserole.Info);
        }
    }
}