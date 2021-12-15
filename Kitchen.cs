using System;
using System.Collections.Generic;
using CreationalDesignPatterns.Cookware;
using CreationalDesignPatterns.Iterator;

namespace CreationalDesignPatterns
{
    public class Kitchen : IIteratorCollection
    {
        private static Kitchen _instance;

        private List<ICookware> _cookwares;

        private Kitchen()
        {
            _cookwares = new List<ICookware>();
        }

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

        public void AddCookware(ICookware cookware)
        {
            _cookwares.Add(cookware);
        }

        public List<ICookware> GetCookwares()
        {
            return _cookwares;
        }
        
        #region IIteratorCollection implementation

        public IIterator<ICookware> Iterator()
        {
            return new CookwareIterator(_cookwares);
        }

        #endregion
    }
}