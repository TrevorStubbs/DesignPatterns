using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Classes
{
    class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific Request";
        }

        public long GetSum(long x, long y)
        {
            return x + y;
        }
    }
}
