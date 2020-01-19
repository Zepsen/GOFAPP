namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Oven oven;

            //Static factory
            oven = Oven.GetOven(DishType.Burger);
            oven.Prepare();
            oven = Oven.GetOven(DishType.Pizza);
            oven.Prepare();

            //Delegate factory
            oven = Oven.GetOven(() => new BurgerOven());
            oven.Prepare();
            oven = Oven.GetOven(() => new PizzaOven());
            oven.Prepare();

            //True factory
            oven = new BurgerCreator().GetOven();
            oven.Prepare();

            oven = new PizzaCreator().GetOven();
            oven.Prepare();

            //Generic true factory
            oven = OvenGenericFactory<PizzaCreator>.Create();
            oven.Prepare();
            oven = OvenGenericFactory<BurgerCreator>.Create();
            oven.Prepare();

        }
    }
}
