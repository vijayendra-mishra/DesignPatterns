using DesignPatterns.FactoryPattern;

namespace Driver.Patterns
{
    public class FactoryRunner : IPatternRunner
    {
        public void Run()
        {
            ShapeFactory sf = new();
            sf.GetShape("Circle").Draw();
            sf.GetShape("Square").Draw();
            sf.GetShape("Rectangle").Draw();
        }
    }
}
