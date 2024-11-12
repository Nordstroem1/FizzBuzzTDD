using FizzBuzz.Interfaces;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzLogic : IFizzBuzz
    {

        public string IsFizz(int number) => number % 3 == 0 ? "Fizz" : string.Empty;
        public string IsBuzz(int number) => number % 5 == 0 ? "Buzz" : string.Empty;
        public string IsWhizz(int number) => number % 7 == 0 ? "Whizz" : string.Empty;
        public string IsBang(int number) => number % 11 == 0 ? "Bang" : string.Empty;

        public string CombinesTheResult(int number)
        {
            if (number < 2) return number.ToString();

            var result = new StringBuilder();

            result.Append(IsFizz(number));
            result.Append(IsBuzz(number));
            result.Append(IsWhizz(number));
            result.Append(IsBang(number));

            return result.Length > 0 ? result.ToString() : number.ToString();
        }
    }
}
