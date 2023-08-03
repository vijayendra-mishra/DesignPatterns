namespace DesignPatterns.StrategyPattern.WithStrategy
{
    public class OffRoadVehicle : Vehicle
    {
        public OffRoadVehicle() : base(new SportsDriveStrategy())
        {

        }
    }
}
