using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Classes
{
    class ConcreteProductB1 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "The result of the product B1.";
        }

        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"The result of the B1 collaboration with the ({result}).";               
        }
    }
}
