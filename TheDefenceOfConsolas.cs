using System;

Console.Title = "Defense of Consolas";

Console.Write("Target Row? ");
int targetRow = Convert.ToInt32(Console.ReadLine());

Console.Write("Target Column? ");
int targetColumn = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Deploy To:");

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"({targetRow}, {targetColumn - 1})");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"({targetRow - 1}, {targetColumn})");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"({targetRow}, {targetColumn + 1})");

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"({targetRow + 1}, {targetColumn})");

Console.Beep();