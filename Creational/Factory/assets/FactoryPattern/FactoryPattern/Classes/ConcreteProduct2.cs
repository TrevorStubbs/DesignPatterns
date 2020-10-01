using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}
