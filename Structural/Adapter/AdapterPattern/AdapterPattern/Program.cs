// Citation: https://refactoring.guru/design-patterns/adapter/csharp/example

using AdapterPattern.Classes;
using AdapterPattern.Interfaces;
using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.Write("This is the adapted class. "); 
            Console.WriteLine(target.GetRequest());

            Console.WriteLine();

            Console.Write("Convert the type of GetSum from long to int: ");
            Console.WriteLine(target.GetSum(50, 50));

        }
    }
}
