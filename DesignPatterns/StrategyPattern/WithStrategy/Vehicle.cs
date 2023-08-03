
namespace DesignPatterns.StrategyPattern.WithStrategy
{
    public class Vehicle
    {
        //has a
        private readonly IDriveStrategy driveStrategy;

        public Vehicle(IDriveStrategy driveStrategy)
        {
            this.driveStrategy = driveStrategy;
        }

        public void Drive()
        {
            driveStrategy.Drive();
        }
    }
}
