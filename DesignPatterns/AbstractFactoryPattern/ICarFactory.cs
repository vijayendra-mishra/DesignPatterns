namespace DesignPatterns.AbstractFactoryPattern
{
    public interface ICarFactory // Abstract Factory
    {
        public ICar GetCar(string carType);
    }
}
