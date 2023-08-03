using DesignPatterns.AbstractFactoryPattern;

namespace Driver.Patterns
{
    public class AbstractFactoryRunner : IPatternRunner
    {
        public void Run()
        {
            CarFactoryOfFactories factorySelector = new();

            ICarFactory luxuryFactory = factorySelector.GetVehicleFactory("luxury");
            ICar luxuryCar = luxuryFactory.GetCar("bmw");
            Console.WriteLine($"Average of Luxury car BMW is : {luxuryCar.GetAverage()}");

            ICarFactory economyFactory = factorySelector.GetVehicleFactory("economy");
            ICar economyCar = economyFactory.GetCar("hyundai");
            Console.WriteLine($"Average of Economy car Hyundai is : {economyCar.GetAverage()}");

        }
    }
}
