
using wos = DesignPatterns.StrategyPattern.WithoutStrategy;
using ws = DesignPatterns.StrategyPattern.WithStrategy;

namespace Driver.Patterns
{
    public class StrategyRunner : IPatternRunner
    {
        public void Run()
        {
            wos.PassengerVehicle pv = new();
            wos.SportsVehicle sv = new();
            wos.OffRoadVehicle orv = new();
            wos.GoodsVehicle gv = new();

            Console.WriteLine();
            Console.WriteLine(" Without Strategy Pattern :");

            pv.Drive();
            gv.Drive();
            orv.Drive();
            sv.Drive(); // Duplicate Code


            Console.WriteLine();
            Console.WriteLine("------------------------------");

            ws.PassengerVehicle pvs = new();
            ws.SportsVehicle svs = new();
            ws.OffRoadVehicle orvs = new();
            ws.GoodsVehicle gvs = new();

            Console.WriteLine("");
            Console.WriteLine(" With Strategy Pattern :");
            pvs.Drive();
            svs.Drive();
            gvs.Drive();
            orvs.Drive(); // No Duplicate Code

        }
    }
}
