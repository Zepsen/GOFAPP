using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var oven = OvenStaticFactory.CreateOven(DishType.Burger);
            oven.Prepare();

            oven = OvenStaticFactory.CreateOven(DishType.Pizza);
            oven.Prepare();
        }
    }
}
