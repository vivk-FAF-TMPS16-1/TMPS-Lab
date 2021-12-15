using System;
using System.Collections;
using System.Collections.Generic;
using CreationalDesignPatterns.Cookware;

namespace CreationalDesignPatterns.Iterator
{
    public class CookwareIterator : IIterator<ICookware>
    {
        private List<ICookware> _cookwares;
        private int _index = -1;

        public CookwareIterator(List<ICookware> cookwares)
        {
            _cookwares = cookwares;
        }
        
        public bool MoveNext()
        {
            return (++_index < _cookwares.Count);
        }

        public void Reset()
        {
            _index = -1;
        }

        public ICookware Current
        {
            get
            {
                try
                {
                    return _cookwares[_index];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
    }
}