namespace FizzBuzz.Tests.Services
{
    public class FizzBuzzServiceTests
    {
        private readonly FizzBuzzService sut = new();

        [Fact]
        public void ShouldReturnNumberWhenNotDivisbleBy3Or5() { 
            var result = sut.GetFizzBuzzOutput(1);
            Assert.Equal("1", result);        
        }

        [Fact]
        public void ShouldPrintBuzzWhenNumberDivisibleBy3()
        {
            var result = sut.GetFizzBuzzOutput(9);
            Assert.Equal("Buzz", result);
        }
    }
}
