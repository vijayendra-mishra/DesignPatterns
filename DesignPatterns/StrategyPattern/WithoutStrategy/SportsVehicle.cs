namespace DesignPatterns.StrategyPattern.WithoutStrategy
{
    public class SportsVehicle : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine(" Sports drive capability : duplicated special need in child");
        }
    }
}
