using System;

Console.WriteLine("Write the triangle's base:");
float triangleBase = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Write the triangle's height:");
float triangleHeight = Convert.ToSingle(Console.ReadLine());

float triangleArea = (triangleBase * triangleHeight) / 2;
Console.WriteLine($"The triangle's area is {triangleArea}");