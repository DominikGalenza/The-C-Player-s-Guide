using System;

Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");

Console.Write("What number do you want to see the price of? ");
int passedNumber = Convert.ToInt32(Console.ReadLine());

switch (passedNumber)
{
    case 1:
        Console.WriteLine("Rope cost 10 gold.");
        break;
    case 2:
        Console.WriteLine("Torches cost 15 gold.");
        break;
    case 3:
        Console.WriteLine("Climbing equipment cost 25 gold.");
        break;
    case 4:
        Console.WriteLine("Clean water cost 1 gold.");
        break;
    case 5:
        Console.WriteLine("Machete cost 20 gold");
        break;
    case 6:
        Console.WriteLine("Canoe cost 200 gold.");
        break;
    case 7:
        Console.WriteLine("Food supplies cost 1 gold");
        break;
    default:
        Console.WriteLine("Sorry, we don't have that number.");
        break;
}       