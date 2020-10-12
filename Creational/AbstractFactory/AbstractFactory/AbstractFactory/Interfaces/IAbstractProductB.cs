using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Interfaces
{
    public interface IAbstractProductB
    {
        string UsefulFunctionB();

        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }
}
