using Factory.Pizzas.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Factories.Base
{
    public interface IPizzeriaFactory
    {
        void Order(IPizza pizza);
    }
}
