using System;

int manticoreHealth = 10;
int cityHealth = 15;
int round = 1;

int manticorePosition = PlaceTheManticore();

while (manticoreHealth > 0 && cityHealth > 0)
{
    Console.WriteLine($"STATUS: Round: {round} City: {cityHealth} Manticore: {manticoreHealth}");

    CalculateDamage(round, manticorePosition);

    round++;
}

EndGame();

int PlaceTheManticore()
{
    Console.Write("Player 1, how far from the city do you want to station the Manticore? ");
    int manticorePosition = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    return manticorePosition;
}

void CalculateDamage(int round, int manticorePosition)
{
    int damage;

    if (round % 3 == 0 && round % 5 == 0)
    {
        damage = 10;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"The cannon is expected to deal {damage} this round.");
    }
    else if (round % 3 == 0 || round % 5 == 0)
    {
        damage = 3;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"The cannon is expected to deal {damage} this round.");
    }
    else
    {
        damage = 1;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"The cannon is expected to deal {damage} this round.");
    }

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Enter desired cannon range: ");
    int cannonRange = Convert.ToInt32(Console.ReadLine());

    if (cannonRange == manticorePosition)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("That round was a DIRECT HIT!");
        manticoreHealth -= damage;
    }
    else if (cannonRange > manticorePosition)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("That round OVERSHOT the target.");
        cityHealth--;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("That round FELL SHORT of the target");
        cityHealth--;
    }
}

void EndGame()
{
    if (manticoreHealth < 1)
    {
        Console.Write("The Manticore has been defeated! The city of Consolas has been saved!");
    }
    else if (cityHealth < 1)
    {
        Console.Write("The city of consola has been destroyed! The Manticore is the winner!");
    }
}