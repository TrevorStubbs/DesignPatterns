// Citation: https://refactoring.guru/design-patterns/singleton/csharp/example#example-1

using System;
using System.Threading;

namespace SingletonPattern_Threadsafe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "{0}\n{1}\n{2}\n",
                "If you see the same value, then we have a true singleton.",
                "If you see difference values, then we have the singleton on different threads.",
                "RESULT:"
                );

            Thread process1 = new Thread(() =>
            {
                TestSingleton("Foo");
            });

            Thread process2 = new Thread(() =>
            {
                TestSingleton("Bar");
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();

        }

        public static void TestSingleton(string value)
        {
            Singleton singleton = Singleton.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }
    }
}
