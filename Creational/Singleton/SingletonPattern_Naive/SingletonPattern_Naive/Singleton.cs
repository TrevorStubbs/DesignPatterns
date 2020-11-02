using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SingletonPattern_Naive
{
    class Singleton
    {
        private static Singleton _instance;

        private Singleton()
        {
            // private constructor makes this class' instantiation unavailable to the outside. 
        }

        public static Singleton GetInsance()
        {
            if(_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        public static void SomeBuisnessLogic()
        {
            Console.WriteLine("I am important stuff");
        }
    }
}
