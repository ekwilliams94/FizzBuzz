namespace FizzBuzz.Strategies
{
    public class Context(IStrategy strategy)
    {
        private IStrategy _strategy = strategy;

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public string ExecuteStrategy()
        {
            return _strategy.Execute();
        }
    }
}
