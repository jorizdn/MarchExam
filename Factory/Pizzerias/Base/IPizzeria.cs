using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Pizzerias.Base
{
    public interface IPizzeria
    {
        string PizzeriaName();
        string Cheese();
        string Clam();
        string Dough();
        string Sauce();
        string Veggies();
        string BoxColor();
    }
}
