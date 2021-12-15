using System;
using System.Collections.Generic;
using CreationalDesignPatterns.Cookware;

namespace CreationalDesignPatterns.Iterator
{
    public interface IIteratorCollection
    {
        IIterator<ICookware> Iterator();
    }
}