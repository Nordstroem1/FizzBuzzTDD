using FizzBuzz;

Console.WriteLine("Type a number and you'll see what it returns.");

int userInputNumber = 0;
try
{
    userInputNumber = Convert.ToInt32(Console.ReadLine());
}
catch
{
    throw new Exception($"{userInputNumber} is not a number.");
}

FizzBuzzLogic fizzBuzzLogic = new FizzBuzzLogic();
fizzBuzzLogic.CombinesTheResult(userInputNumber);
Console.ReadLine();