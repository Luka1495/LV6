using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IAbstractCollection
    {
        IAbstractIterator GetIterator();
    }
}
