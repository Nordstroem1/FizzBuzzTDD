namespace FizzBuzz
{
    public class FizzBuzzLogic
    {
        public string ReturnsFizzBuzzInDiffrentWays(int number)
        {
            string result = number switch
            {
                _ when number % 3 == 0 => "Fizz",
                _ when number % 5 == 0 => "Buzz",
                _ when number % 3 == 0 && number % 5 == 0 => "FizzBuzz",
                _ => number.ToString()
            };
            Console.WriteLine(result);

            return result;
        }
    }
}
