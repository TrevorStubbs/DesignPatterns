// Citation: https://refactoring.guru/design-patterns/singleton/csharp/example#example-0

using System;

namespace SingletonPattern_Naive
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInsance();
            Singleton s2 = Singleton.GetInsance();

            if(s1 == s2)
            {
                Console.WriteLine($"Singleton works. Variable s1 points to {s1.GetHashCode()}, variable s2 points to {s2.GetHashCode()}. Are they the same? {s1.GetHashCode() == s2.GetHashCode()}");                
            }
            else
            {
                Console.WriteLine("Singleton failed.");
            }
        }
    }
}
