namespace DesignPatterns.DecoratorPattern
{
    public class ExtraCheese : ToppingDecorator
    {
        //has - a relationship with base class PizzaBase
        private readonly PizzaBase pizzaBase;

        public ExtraCheese(PizzaBase pizzaBase)
        {
            this.pizzaBase = pizzaBase;
        }

        public override int Cost()
        {
            return this.pizzaBase.Cost() + 15; //15 being extra cheese cost
        }


    }
}
