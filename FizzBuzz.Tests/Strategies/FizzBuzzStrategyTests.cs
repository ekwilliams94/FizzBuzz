using FizzBuzz.Strategies;

namespace FizzBuzz.Tests.Strategies
{
    public class FizzBuzzStrategyTests
    {
        private readonly FizzBuzzStrategy sut = new();

        [Fact]
        public void ShouldReturnFizzBuzz()
        {
            var result = sut.Execute();
            Assert.Equal("FizzBuzz", result);
        }
    }
}
