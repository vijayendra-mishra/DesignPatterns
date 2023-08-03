namespace DesignPatterns.StrategyPattern.WithStrategy
{
    public class NormalDriveStrategy : IDriveStrategy
    {
        public void Drive()
        {
            Console.WriteLine(" Normal drive capability : from strategy");
        }
    }
}
