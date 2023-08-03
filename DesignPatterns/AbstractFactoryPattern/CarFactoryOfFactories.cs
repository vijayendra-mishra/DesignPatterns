namespace DesignPatterns.AbstractFactoryPattern
{
    public class CarFactoryOfFactories // Abstract Factory Producer
    {
        public ICarFactory GetVehicleFactory(string factoryName)
        {
            return factoryName.ToLower() switch
            {
                "luxury" => new LuxuryCarFactory(),
                "economy" => new EconomyCarFactory(),
                _ => null
            };
        }
    }
}
