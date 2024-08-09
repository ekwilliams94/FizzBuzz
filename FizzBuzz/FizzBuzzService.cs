
using FizzBuzz.Strategies;

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
            return null;
        }
    }
}
