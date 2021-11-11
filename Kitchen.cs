using System;
using CreationalDesignPatterns.Cookware;

namespace CreationalDesignPatterns
{
    public class Kitchen
    {
        private static Kitchen _instance;
        
        private Kitchen() { }

        public static Kitchen Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Kitchen();
                return _instance;
            }
        }

        public void Present(ICookware[] cookwares)
        {
            Console.WriteLine("Kitchen contains following cookware");
            foreach (var cookware in cookwares)
            {
                Console.WriteLine(cookware.Info);
            }
        }
    }
}