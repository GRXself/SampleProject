using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }
        
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void ReturnFalseGivenValueLessThan2(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(11)]
        public void ReturnTrueGivenValueIsPrime(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.True(result, $"{value} is a prime number!");
        }

        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        public void ReturnFalseGivenValueNotPrime(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} is not a prime number!");
        }
    }
}