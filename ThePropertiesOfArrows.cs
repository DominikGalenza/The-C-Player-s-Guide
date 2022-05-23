using System;

using System;

Arrow arrow = GetArrow();
Console.WriteLine($"Your chosen arrow costs {arrow.GetCost()} gold.");

Arrow GetArrow()
{
    Arrowhead arrowhead = GetArrowhead();
    Fletching fletching = GetFletching();
    float shaftLength = GetShaftLength();

    return new Arrow(arrowhead, fletching, shaftLength);
}

Arrowhead GetArrowhead()
{
    Console.WriteLine("Choose arrowhead material from steel, wood or obsidian:");
    string arrowhead = Console.ReadLine();

    return arrowhead switch
    {
        "steel" => Arrowhead.Steel,
        "wood" => Arrowhead.Wood,
        "obsidian" => Arrowhead.Obsidian
    };
}

Fletching GetFletching()
{
    Console.WriteLine("Choose fletching material from plastic, turkey feathers or goose feathers:");
    string fletching = Console.ReadLine();

    return fletching switch
    {
        "plastic" => Fletching.Plastic,
        "turkey feathers" => Fletching.TurkeyFeathers,
        "goose feathers" => Fletching.GooseFeathers
    };
}

float GetShaftLength()
{
    float shaftLength = 0;

    while (shaftLength < 60 || shaftLength > 100)
    {
        Console.WriteLine("Choose shaft length from 60 and 100 cm:");
        shaftLength = Convert.ToSingle(Console.ReadLine());
    }

    return shaftLength;
}

public class Arrow
{
    public Arrowhead Arrowhead { get; }
    private Fletching Fletching { get; }
    private float ShaftLength { get; }

    public Arrow(Arrowhead arrowhead, Fletching fletching, float shaftLength)
    {
        Arrowhead = arrowhead;
        Fletching = fletching;
        ShaftLength = shaftLength;
    }

    public float GetCost()
    {
        float arrowheadCost = Arrowhead switch
        {
            Arrowhead.Steel => 10,
            Arrowhead.Wood => 3,
            Arrowhead.Obsidian => 5
        };

        float fletchingCost = Fletching switch
        {
            Fletching.Plastic => 10,
            Fletching.TurkeyFeathers => 5,
            Fletching.GooseFeathers => 3
        };

        float shaftCost = ShaftLength * 0.05f;

        return arrowheadCost + fletchingCost + shaftCost;
    }
}

public enum Arrowhead { Steel, Wood, Obsidian };
public enum Fletching { Plastic, TurkeyFeathers, GooseFeathers };