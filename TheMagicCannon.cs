using System;

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{i}: Combined");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i}: Fire");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i}: Electric");
    }
    else
    {
        Console.WriteLine($"{i}: Normal");
    }
}