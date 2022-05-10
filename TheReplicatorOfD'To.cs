using System;

int[] numbers = new int[5];

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("Write a number:");
    int number = Convert.ToInt32(Console.ReadLine());
    numbers[i] = number;
}

int[] numbersCopy = new int[5];

for (int i = 0; i < numbersCopy.Length; i++)
{
    numbersCopy[i] = numbers[i];
    Console.WriteLine($"Number: {numbers[i]} and its copy: {numbersCopy[i]}.");
}
