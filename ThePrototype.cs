using System;

Console.Write("User 1, enter a number between 0 and 100: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

while (firstNumber < 0 || firstNumber > 100)
{
    Console.Write("User 1, enter a number between 0 and 100: ");
    firstNumber = Convert.ToInt32(Console.ReadLine());
}

Console.Clear();
Console.WriteLine("User 2, guess the number. ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

while (firstNumber != secondNumber)
{
    if (firstNumber > secondNumber)
    {
        Console.WriteLine($"{secondNumber} is too low.");
    }
    else
    {
        Console.WriteLine($"{secondNumber} is too high.");
    }
    Console.Write("What is your next guess? ");
    secondNumber = Convert.ToInt32(Console.ReadLine());
}

Console.Write("You guessed the number!");