using System;

namespace FactoryMethod
{
    /// <summary>
    /// Base class for oven
    /// </summary>
    public abstract class Oven
    {
        public abstract void Prepare();

        /// <summary>
        /// Simple static factory method
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Oven GetOven(DishType type) => type switch
        {
            DishType.Pizza => new PizzaOven(),
            DishType.Burger => new BurgerOven(),
            _ => throw new System.ArgumentOutOfRangeException(nameof(DishType), $"Sorry, I can't do it"),
        };

        /// <summary>
        /// Simple delegate factory method 
        /// </summary>
        /// <param name="getOven">Delegate that return instance of Oven</param>
        /// <returns></returns>
        public static Oven GetOven(Func<Oven> getOven) => getOven();
    }

    /// <summary>
    /// Oven for pizza
    /// </summary>
    public class PizzaOven : Oven
    {
        public override void Prepare()
        {
            Console.WriteLine("Pizza prepared");
        } 
    }

    /// <summary>
    /// Oven for burger
    /// </summary>
    public class BurgerOven : Oven
    {
        public override void Prepare()
        {
            Console.WriteLine("Burger prepared");
        } 
    }
}
