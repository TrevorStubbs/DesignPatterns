using AdapterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Classes
{
    class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is '{_adaptee.GetSpecificRequest()}'";
        }

        public int GetSum(int x, int y)
        {
            long xLong = (long)x;
            long yLong = (long)y;


            long longSum = _adaptee.GetSum(xLong, yLong);

            int sum = (int)longSum;

            return sum;
        }
    }
}
