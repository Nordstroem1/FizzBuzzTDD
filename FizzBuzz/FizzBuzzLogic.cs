using FizzBuzz.Interfaces;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FizzBuzz
{
    public class FizzBuzzLogic : IFizzBuzz
    {

        public string IsFizz(int number) => number % 3 == 0 ? "Fizz" : string.Empty;
        public string IsBuzz(int number) => number % 5 == 0 ? "Buzz" : string.Empty;
        public string IsWhizz(int number) => number % 7 == 0 ? "Whizz" : string.Empty;
        public string IsBang(int number) => number % 11 == 0 ? "Bang" : string.Empty;
        public string IsFizzBuzz(int number) => number % 3 == 0 && number % 5 == 0 ? "FizzBuzz" : string.Empty;
        public string IsFizzBang(int number) => number % 3 == 0 && number % 11 == 0 ? "FizzBang" : string.Empty;
        public string IsFizzWhizz(int number) => number % 3 == 0 && number % 7 == 0 ? "FizzWhizz" : string.Empty;
        public string IsWhizzBang(int number) => number % 7 == 0 && number % 11 == 0 ? "WizzBang" : string.Empty;
        public string IsBuzzWhizz(int number) => number % 5 == 0 && number % 7 == 0 ? "BuzzWhizz" : string.Empty;
        public string IsBuzzBang(int number) => number % 5 == 0 && number % 11 == 0 ? "BuzzBang" : string.Empty;
        public string IsFizzBuzzWhizz(int number) => number % 3 == 0 && number % 5 == 0 && number % 7 == 0 ? "FizzBuzzWhizz" : string.Empty;
        public string IsFizzBuzzBang(int number) => number % 3 == 0 && number % 5 == 0 && number % 11 == 0 ? "FizzBuzzBang" : string.Empty;
        public string IsFizzWhizzBang(int number) => number % 3 == 0 && number % 7 == 0 && number % 11 == 0 ? "FizzWhizzBang" : string.Empty;
        public string IsFizzBuzzWhizzBang(int number) => number % 3 == 0 && number % 5 == 0 && number % 7 == 0 && number % 11 == 0 ? "FizzBuzzWhizzBang" : string.Empty;

        public string CombinesTheResult(int number)
        {
            if (number < 2) return number.ToString();

            var result = new StringBuilder();

            result.Append(IsFizzBuzzWhizzBang(number));
            result.Append(IsFizzBuzzBang(number));
            result.Append(IsFizzWhizzBang(number));
            result.Append(IsFizzBuzzWhizz(number));
            result.Append(IsFizzBuzz(number));
            result.Append(IsFizzBang(number));
            result.Append(IsFizzWhizz(number));
            result.Append(IsWhizzBang(number));
            result.Append(IsBuzzWhizz(number));
            result.Append(IsBuzzBang(number));


            if (!result.ToString()!.Contains("Fizz") && (!result.ToString()!.Contains("Buzz") &&
                !result.ToString()!.Contains("Whizz") && (!result.ToString()!.Contains("Bang"))))
            {
                result.Append(IsFizz(number));
                result.Append(IsBuzz(number));
                result.Append(IsWhizz(number));
                result.Append(IsBang(number));
            }

            return result.Length > 0 ? result.ToString() : number.ToString();
        }
    }
}
