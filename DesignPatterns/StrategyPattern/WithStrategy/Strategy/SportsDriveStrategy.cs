namespace DesignPatterns.StrategyPattern.WithStrategy
{
    public class SportsDriveStrategy : IDriveStrategy
    {
        public void Drive()
        {
            Console.WriteLine(" Sports drive capability : from strategy");
        }
    }
}
