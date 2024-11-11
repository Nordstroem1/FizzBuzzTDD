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

            var result = _fizzBuzzLogic.IsFizz(testNumber);

            Assert.Equal(resultShouldBe, result);
        }

        [Trait("FizzBuzzTest", "ReturnsFizzBuzzInDiffrentWays")]
        [Theory]
        [InlineData(5)]
        public void ShouldReturnBuzzWithNumberDividedBy5(int testNumber)
        {
            string resultShouldBe = "Buzz";

            var result = _fizzBuzzLogic.IsBuzz(testNumber);

            Assert.Equal(resultShouldBe, result);
        }

        [Trait("FizzBuzzTest", "ReturnsFizzBuzzInDiffrentWays")]
        [Theory]
        [InlineData(15)]
        public void ShouldReturnFizzBuzzWithNumberDividedBy3And5(int testNumber)
        {
            string resultShouldBe = "FizzBuzz";

            var result = _fizzBuzzLogic.CombinesTheResult(testNumber);

            Assert.Equal(resultShouldBe, result);
        }

        [Trait("FizzBuzzTest", "ReturnsFizzBuzzInDiffrentWays")]
        [Theory]
        [InlineData(1)]
        public void ShouldReturnNumberAsStringWithNumberNotDividedBy3Or5(int testNumber)
        {
            string resultShouldBe = testNumber.ToString();

            var result = _fizzBuzzLogic.CombinesTheResult(testNumber);

            Assert.Equal(resultShouldBe, result);
        }

        [Trait("FizzBuzzTest", "ReturnsFizzBuzzInDiffrentWays")]
        [Theory]
        [InlineData(21)]
        public void ShouldReturnFizzWhizzWhenNumberDividedBy7And11(int testNumber)
        {
            string resultShouldBe = "FizzWhizz";

            var result = _fizzBuzzLogic.CombinesTheResult(testNumber);

            Assert.Equal(resultShouldBe, result);
        }
        [Trait("FizzBuzzTest", "ReturnsFizzBuzzInDiffrentWays")]
        [Theory]
        [InlineData(55)]
        public void ShouldReturnBuzzBangWhenNumberDividedBy5And7(int testNumber)
        {
            string resultShouldBe = "BuzzBang";

            var result = _fizzBuzzLogic.CombinesTheResult(testNumber);

            Assert.Equal(resultShouldBe, result);
        }
        [Trait("FizzBuzzTest", "ReturnsFizzBuzzInDiffrentWays")]
        [Theory]
        [InlineData(1155)]
        public void ShouldReturnFizzBuzzWhizzBangWhenNumberDividedBy3And5And7And11(int testNumber)
        {
            string resultShouldBe = "FizzBuzzWhizzBang";

            var result = _fizzBuzzLogic.CombinesTheResult(testNumber);

            Assert.Equal(resultShouldBe, result);
        }
    }
}