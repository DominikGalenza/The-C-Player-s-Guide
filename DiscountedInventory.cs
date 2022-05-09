using System;

Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");

Console.WriteLine("What is your name?");
string passedName = Console.ReadLine();

Console.Write("What number do you want to see the price of? ");
int passedNumber = Convert.ToInt32(Console.ReadLine());

switch (passedNumber)
{
    case 1:
        if (passedName == "Brian")
        {
            Console.WriteLine("Rope cost 5 gold.");
        }
        else
        {
            Console.WriteLine("Rope cost 10 gold.");
        }
        break;
    case 2:
        if (passedName == "Brian")
        {
            Console.WriteLine("Torches cost 7.5 gold.");
        }
        else
        {
            Console.WriteLine("Torches cost 15 gold.");
        }
        break;
    case 3:
        if (passedName == "Brian")
        {
            Console.WriteLine("Climbing equipment cost 12.5 gold.");
        }
        else
        {
            Console.WriteLine("Climbing equipment cost 25 gold.");
        }
        break;
    case 4:
        if (passedName == "Brian")
        {
            Console.WriteLine("Clean water cost 0.5 gold.");
        }
        else
        {
            Console.WriteLine("Clean water cost 1 gold.");
        }
        break;
    case 5:
        if (passedName == "Brian")
        {
            Console.WriteLine("Machete cost 10 gold");
        }
        else
        {
            Console.WriteLine("Machete cost 20 gold");
        }
        break;
    case 6:
        if (passedName == "Brian")
        {
            Console.WriteLine("Canoe cost 100 gold.");
        }
        else
        {
            Console.WriteLine("Canoe cost 200 gold.");
        }
        break;
    case 7:
        if (passedName == "Brian")
        {
            Console.WriteLine("Food supplies cost 0.5 gold");
        }
        else
        {
            Console.WriteLine("Food supplies cost 1 gold");
        }
        break;
    default:
        Console.WriteLine("Sorry, we don't have that number.");
        break;
}