using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Interfaces
{
    public interface ITarget
    {
        string GetRequest();

        int GetSum(int x, int y);
    }
}
