using Driver;
using Driver.Patterns;

while (true)
{
    Console.WriteLine();
    Console.WriteLine("----------------------------------------------------------------------------");
    Console.WriteLine("----------------------------------------------------------------------------");
    Console.WriteLine();
    Console.WriteLine("Choose Pattern to run from below :");

    foreach (int i in Enum.GetValues(typeof(PatternType)))
    {
        Console.WriteLine(i + ": " + Enum.GetName(typeof(PatternType), i));
    }

    Console.WriteLine();

    if (Int32.TryParse(Console.ReadLine(), out int patternNo))
    {
        PatternSelector selectedPattern;

        selectedPattern = patternNo switch
        {
            0 => new PatternSelector(new StrategyRunner()),
            1 => new PatternSelector(new ObserverRunner()),
            2 => new PatternSelector(new DecoratorRunner()),
            3 => new PatternSelector(new FactoryRunner()),
            4 => new PatternSelector(new AbstractFactoryRunner()),
            _ => new PatternSelector(new StrategyRunner()),
        };

        selectedPattern.Run();
    }
    else
    {
        Console.WriteLine("--------------INCORRECT INPUT--------------");
    }
}