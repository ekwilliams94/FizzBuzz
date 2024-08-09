
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

        public Type? GetType()
        {
            throw new NotImplementedException();
        }
    }
}
