namespace FactoryMethod
{
    public enum DishType
    {
        Pizza = 1,
        Burger = 2
    }

    public class OvenStaticFactory
    {
        private OvenStaticFactory()
        {

        }

        public static Oven CreateOven(DishType type)
        {
            switch (type)
            {
                case DishType.Pizza:
                    return new PizzaOven();
                case DishType.Burger:
                    return new BurgerOven();
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(DishType), $"I can't do it");
            }
        }
    }
}
