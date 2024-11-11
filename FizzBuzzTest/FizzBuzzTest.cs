using FizzBuzz;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzTest : IClassFixture<FizzBuzzFixture>
    {
        private readonly FizzBuzzLogic _fizzBuzzLogic;

        public FizzBuzzTest(FizzBuzzFixture fixture)
        {
            _fizzBuzzLogic = fixture.FizzBuzzLogic;
        }

        [Trait("FizzBuzzTest", "ReturnsFizzBuzzInDiffrentWays")]
        [Theory]
        [InlineData(3)]
        public void ShouldReturnFizzWithNumberDividedBy3(int testNumber)
        {
            string resultShouldBe = "Fizz";

            var result = _fizzBuzzLogic.ReturnsFizzBuzzInDiffrentWays(testNumber);

            Assert.Equal(resultShouldBe, result);
        }
    }
}