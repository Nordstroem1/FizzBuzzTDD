using FizzBuzz;

Console.WriteLine("Type a number and you'll see what it returns.");
int UserInputNumber = 0;
try
{
    UserInputNumber = Convert.ToInt32(Console.ReadLine());
}
catch
{
    Console.WriteLine("Input must be a number´.");
}

FizzBuzzLogic fizzBuzzLogic = new FizzBuzzLogic();
fizzBuzzLogic.ReturnsFizzBuzzInDiffrentWays(UserInputNumber);
Console.ReadLine();