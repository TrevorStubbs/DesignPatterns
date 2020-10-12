using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Classes
{
    class ConcreteProductA2 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of product A2.";
        }
    }
}
