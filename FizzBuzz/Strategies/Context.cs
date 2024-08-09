namespace FizzBuzz.Strategies
{
    public class Context(IFizzBuzzStrategy strategy)
    {
        private IFizzBuzzStrategy _strategy = strategy;

        public void SetStrategy(IFizzBuzzStrategy strategy)
        {
            _strategy = strategy;
        }

        public string ExecuteStrategy()
        {
            return _strategy.Execute();
        }
    }
}
