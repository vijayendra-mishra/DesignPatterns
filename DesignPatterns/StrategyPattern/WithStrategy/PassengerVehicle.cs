namespace DesignPatterns.StrategyPattern.WithStrategy
{
    public class PassengerVehicle : Vehicle
    {
        public PassengerVehicle() : base(new NormalDriveStrategy())
        {

        }
    }
}
