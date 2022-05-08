using System;

Console.WriteLine("How many provinces do you have?");
int numberOfProvinces = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many duchies do you have?");
int numberOfDuchies = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many estates do you have?");
int numberOfEstates = Convert.ToInt32(Console.ReadLine());

int numberOfPoints = numberOfProvinces * 6 + numberOfDuchies * 3 + numberOfEstates;
Console.WriteLine($"You have {numberOfPoints} points");