using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class Oven
    {
        public abstract void Prepare();
    }

    public class PizzaOven : Oven
    {
        public override void Prepare()
        {
            Console.WriteLine("Pizza prepared");
        } 
    }

    public class BurgerOven : Oven
    {
        public override void Prepare()
        {
            Console.WriteLine("Burger prepared");
        } 
    }
}
