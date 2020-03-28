using Factory.Factories;
using Factory.Factories.Base;
using Factory.Pizzas;
using Factory.Pizzerias;
using Factory.Pizzerias.Base;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizzeriaFactory factory = new PizzeriaFactory();
            factory.Order(new Veggie(new PizzeriaB()));
            Console.ReadLine();
        }
    }
}
