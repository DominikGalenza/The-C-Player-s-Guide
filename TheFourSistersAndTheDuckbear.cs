using System;

Console.WriteLine("How many chocolate eggs did the sisters gather today?");

int eggsCount = Convert.ToInt32(Console.ReadLine());
int eggsForSisters = eggsCount / 4;
int eggsForDuckbear = eggsCount % 4;

Console.WriteLine($"Sisters got {eggsForSisters} eggs, and Duckbear got {eggsForDuckbear} eggs.");
