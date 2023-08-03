namespace DesignPatterns.StrategyPattern.WithStrategy
{
    public class GoodsVehicle : Vehicle
    {
        public GoodsVehicle() : base(new NormalDriveStrategy())
        {

        }
    }
}
