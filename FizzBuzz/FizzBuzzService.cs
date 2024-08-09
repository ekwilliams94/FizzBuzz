
using FizzBuzz.Strategies;
using System.Reflection;

namespace FizzBuzz
{
    public class FizzBuzzService
    {
        public string GetFizzBuzzOutput(int input)
        {
            var strategyType = GetStrategyType(input);

            if (strategyType != null)
            {
                var strategyInstance = Activator.CreateInstance(strategyType) as IStrategy;

                var context = new Context(strategyInstance);
                return context.ExecuteStrategy();
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
