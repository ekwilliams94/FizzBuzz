
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
                .Where(t => typeof(IStrategy).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract);

                if(input % 3 == 0 && input % 5 == 0)
                {
                    return strategyTypes.FirstOrDefault(GetStrategyType => GetStrategyType.Name.Contains("FizzBuzzStrategy"));
                }
                if (input % 3 == 0)
                {
                    return strategyTypes.FirstOrDefault(GetStrategyType => GetStrategyType.Name.Contains("FizzStrategy"));
            }
                if (input % 5 == 0)
                {
                    return strategyTypes.FirstOrDefault(GetStrategyType => GetStrategyType.Name.Contains("BuzzStrategy"));
                }

            return null;
        }
    }
}
