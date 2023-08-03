using DesignPatterns.DecoratorPattern;

namespace Driver.Patterns
{
    public class DecoratorRunner : IPatternRunner
    {
        public void Run()
        {
            PizzaBase pizza1 = new ExtraCheese(new Margherita()); //decorator wraps base
            Console.WriteLine($"Cost of Margherita with Extra Cheese is: {pizza1.Cost()}!" );

            PizzaBase pizza2 = new ExtraCheese(new Mushroom(new Farmhouse())); //decorator 2 wraps decorator 1 and base
            Console.WriteLine($"Cost of Farmhouse with Mushroom & Extra Cheese is: {pizza2.Cost()}!");
        }
    }
}
