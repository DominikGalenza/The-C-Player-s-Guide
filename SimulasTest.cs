using System;

ChestState state = ChestState.Locked;

while (true)
{
    Console.Write($"The chest is {state}. What do you want to do? ");
    string action = Console.ReadLine();

    if (state == ChestState.Locked && action == "unlock")
    {
        state = ChestState.Closed;
    }
    else if (state == ChestState.Closed && action == "open")
    {
        state = ChestState.Open;
    }
    else if (state == ChestState.Open && action == "close")
    {
        state = ChestState.Closed;
    }
    else if (state == ChestState.Closed && action == "lock")
    {
        state = ChestState.Locked;
    }
}

enum ChestState { Locked, Closed, Open };