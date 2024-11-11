using FizzBuzz;

namespace FizzBuzzTest
{
    public class FizzBuzzFixture
    {
        public FizzBuzzLogic FizzBuzzLogic { get; private set; }
        public FizzBuzzFixture()
        {
            FizzBuzzLogic = new FizzBuzzLogic();
        }
    }
}
