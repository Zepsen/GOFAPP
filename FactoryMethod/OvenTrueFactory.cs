using System;
namespace FactoryMethod
{
    /// <summary>
    /// True factory implementation
    /// </summary>
    public abstract class OvenTrueFactory
    {
        internal OvenTrueFactory() { }

        internal abstract Oven GetOven();
    }

    /// <summary>
    /// Generic factory for true factory implementation
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class OvenGenericFactory<T> where T : OvenTrueFactory, new()
    {
        /// <summary>
        /// Reflection
        /// </summary>
        /// <returns></returns>
        public static Oven Create()
        {
            try
            {
                var oven = new T();
                return oven.GetOven();
            }
            catch (Exception)
            {
                throw new ArgumentException("Sorry, I can't do it");
            }
        }
    }

    /// <summary>
    /// Pizza creator
    /// </summary>
    public class PizzaCreator : OvenTrueFactory
    {
        internal override Oven GetOven() => new PizzaOven();
    }

    /// <summary>
    /// Burger creator
    /// </summary>
    public class BurgerCreator : OvenTrueFactory
    {
        internal override Oven GetOven() => new BurgerOven();
    }
}
