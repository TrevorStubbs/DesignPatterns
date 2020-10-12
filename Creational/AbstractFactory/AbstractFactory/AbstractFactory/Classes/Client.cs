using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Classes
{
    class Client
    {
        public void Main()
        {
            Console.WriteLine("Client: Testing the client code with the first factory type...");
            ClientMethod(new ConcreteFactory1());

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new ConcreteFactory2());
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }
    }
}
