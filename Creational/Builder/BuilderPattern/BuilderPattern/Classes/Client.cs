using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Client
    {
        public void Main()
        {
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;

            Console.WriteLine("Standard basic product: ");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine();

            Console.WriteLine("Standard full featured product: ");
            director.BuildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine();

            Console.WriteLine("Custom product: ");
            builder.BuildPartA();
            builder.BuildPartC();
            Console.WriteLine(builder.GetProduct().ListParts());

        }
    }
}
