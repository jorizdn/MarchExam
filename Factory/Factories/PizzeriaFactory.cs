using Factory.Factories.Base;
using Factory.Pizzas.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Factory.Factories
{
    public class PizzeriaFactory : IPizzeriaFactory
    {
        public void Order(IPizza pizza)
        {
            pizza.Prepare();
            Thread.Sleep(3000);
            pizza.Bake();
            Thread.Sleep(3000);
            pizza.Cut();
            Thread.Sleep(3000);
            pizza.Box();
        }
    }
}
