using Factory.Constants;
using Factory.Pizzas.Base;
using Factory.Pizzerias.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Pizzas
{
    public class Cheese : IPizza
    {
        private readonly IPizzeria _pizzeria;

        public Cheese(IPizzeria pizzeria)
        {
            _pizzeria = pizzeria;
        }

        public void Prepare()
        {
            Console.WriteLine($"Preparing {_pizzeria.PizzeriaName()} Style Cheese using");
            Console.WriteLine($"Dough: {_pizzeria.Dough()}, Cheese: {_pizzeria.Cheese()}, Sauce: {_pizzeria.Sauce()}, Veggies: {_pizzeria.Veggies()}");
        }

        public void Bake()
        {
            Console.WriteLine(Steps.Bake);
        }

        public void Cut()
        {
            Console.WriteLine(Steps.Cut);
        }

        public void Box()
        {
            Console.WriteLine($"Putting pizza in {_pizzeria.BoxColor()} colored box");
        }
    }
}
