namespace DesignPatterns.StrategyPattern.WithStrategy
{
    public class SportsVehicle : Vehicle
    {
        public SportsVehicle() : base(new SportsDriveStrategy())
        {

        }
    }
}
