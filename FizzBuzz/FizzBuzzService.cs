
using FizzBuzz.Strategies;
using System.Reflection;

namespace FizzBuzz
{
    public class FizzBuzzService
    {
        public string GetFizzBuzzOutput(int input)
        {
            var BuzzStrategy = new BuzzStrategy();
            if (input % 3 == 0)
            {
                return BuzzStrategy.Execute();
            }
            return input.ToString();
        }

        public Type? GetStrategyType(int input)
        {
            var strategyTypes = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(IFizzBuzzStrategy).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract);

            foreach (var type in strategyTypes)
            {
                if (type.Name.Contains("Fizz") && input % 3 == 0)
                {
                    return type;
                }
                if (type.Name.Contains("Buzz") && input % 5 == 0)
                {
                    return type;
                }
            }

            return null;
        }
    }
}
