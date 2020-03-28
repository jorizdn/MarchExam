using Factory.Constants;
using Factory.Pizzerias.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Pizzerias
{
    public class PizzeriaB : IPizzeria
    {
        public string PizzeriaName() => "Pizzeria B";
        public string Cheese() => Ingredients.Parmesan;
        public string Clam() => Ingredients.FreshClam;
        public string Dough() => Ingredients.DeepDish;
        public string Sauce() => Ingredients.PlumTomato;
        public string Veggies() => string.Join(", ", Ingredients.Cucumber, Ingredients.Onions, Ingredients.BellPeppers);
        public string BoxColor() => Color.Green;
    }
}
