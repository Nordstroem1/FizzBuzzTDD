using FizzBuzz;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Xunit;
using Xunit.Abstractions;

namespace FizzBuzzTest
{
    public class FizzBuzzTest : IClassFixture<FizzBuzzFixture>
    {
        private readonly FizzBuzzLogic _fizzBuzzLogic;
        public ITestOutputHelper _output;

        public FizzBuzzTest(FizzBuzzFixture fixture, ITestOutputHelper output)
        {
            _fizzBuzzLogic = fixture.FizzBuzzLogic;
            _output = output;
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

        [Trait("FizzBuzzTestEdgeCase", "ReturnsFizzBuzzInDiffrentWays")]
        [Theory]
        [InlineData(-1,-6,0)]
        [InlineData(1,2,4)]
        [InlineData(8,13,-1)]
        public void ShouldReturnInputNumberAsTheResultNotAbleToDivideByAnyNumber(int testNumber1, int testNumber2, int testNumber3)
        {
            string resultShouldBe = testNumber1.ToString();
            string resultShouldBe2 = testNumber2.ToString();
            string resultShouldBe3 = testNumber3.ToString();

            var result = _fizzBuzzLogic.CombinesTheResult(testNumber1);
            var result2 = _fizzBuzzLogic.CombinesTheResult(testNumber2);
            var result3 = _fizzBuzzLogic.CombinesTheResult(testNumber3);

            _output.WriteLine(result);
            _output.WriteLine(result2);
            _output.WriteLine(result3);

            Assert.Equal(resultShouldBe, result);
            Assert.Equal(resultShouldBe2, result2);
            Assert.Equal(resultShouldBe3, result3);
        }
    }
}