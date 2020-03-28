using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Pizzas.Base
{
    public interface IPizza
    {
        void Prepare();
        void Bake();
        void Cut();
        void Box();
    }
}
