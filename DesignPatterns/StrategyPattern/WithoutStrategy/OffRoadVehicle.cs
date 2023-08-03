namespace DesignPatterns.StrategyPattern.WithoutStrategy
{
    public class OffRoadVehicle : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine(" Sports drive capability : special need in child");
        }
    }
}
