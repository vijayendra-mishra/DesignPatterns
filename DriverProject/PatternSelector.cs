
using Driver.Patterns;

namespace Driver
{
    public class PatternSelector
    {
        private readonly IPatternRunner patternRunner;
        public PatternSelector(IPatternRunner patternRunner)
        {
            this.patternRunner = patternRunner;
        }

        public void Run()
        {
            patternRunner.Run();
        }
    }
}
