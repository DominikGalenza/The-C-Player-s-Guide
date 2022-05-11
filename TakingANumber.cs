using System;

AskForNumber("Write a random number");

AskForNumberInRange("Write a number in range from 25 to 49", 25, 49);

int AskForNumber(string text)
{
    Console.WriteLine(text);
    int passedNumber = Convert.ToInt32(Console.ReadLine());
    return passedNumber;
}

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        int passedNumber = AskForNumber(text);
        if (passedNumber >= min && passedNumber <= max)
        {
            return passedNumber;
        }
    }
}