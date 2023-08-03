namespace DesignPatterns.AbstractFactoryPattern
{
    public class LuxuryCarFactory : ICarFactory
    {
        public ICar GetCar(string carType)
        {
            return carType.ToLower() switch
            {
                "bmw" => new BMW(),
                "mercedes" => new Mercedes(), // returns object of actual products
                _ => null,
            };
        }
    }
}
