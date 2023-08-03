namespace DesignPatterns.DecoratorPattern
{
    public class Mushroom : ToppingDecorator
    {
        //has - a relationship with base class PizzaBase
        private readonly PizzaBase pizzaBase;

        public Mushroom(PizzaBase pizzaBase)
        {
            this.pizzaBase = pizzaBase;
        }
        public override int Cost()
        {
            return pizzaBase.Cost() + 10; //10 being extra mushroom cost
        }
    }
}
