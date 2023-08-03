namespace DesignPatterns.AbstractFactoryPattern
{
    public class EconomyCarFactory : ICarFactory
    {
        public ICar GetCar(string carType)
        {
            return carType.ToLower() switch
            {
                "maruti" => new Maruti(),
                "hyundai" => new Hyundai(), // returns object of actual products
                _ => null,
            };
        }
    }
}
