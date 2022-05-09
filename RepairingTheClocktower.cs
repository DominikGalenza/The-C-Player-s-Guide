using System;

Console.WriteLine("Write a number:");
int passedNumber = Convert.ToInt32(Console.ReadLine());

if (passedNumber % 2 == 0)
{
    Console.WriteLine("Tick");
}
else
{
    Console.WriteLine("Tock");
}