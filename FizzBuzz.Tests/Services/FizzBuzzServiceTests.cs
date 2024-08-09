namespace FizzBuzz.Tests.Services
{
    public class FizzBuzzServiceTests
    {
        private readonly FizzBuzzService sut = new();

        [Fact]
        public void ShouldPrintBuzzWhenNumberDivisibleBy3()
        {
            var result = sut.GetFizzBuzzOutput();
            Assert.Equal("Buzz", result);
        }
    }
}
