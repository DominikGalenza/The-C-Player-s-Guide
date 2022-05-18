using System;

(FoodType foodType, MainIngredient mainIngredient, Seasoning seasoning)[] soups = new (FoodType, MainIngredient, Seasoning)[3];

for (int i = 0; i < soups.Length; i++)
{
    soups[i] = GetFood();
    Console.WriteLine($"{soups[i].foodType} {soups[i].mainIngredient} {soups[i].seasoning}");
}

(FoodType, MainIngredient, Seasoning) GetFood()
{
    FoodType foodType = GetFoodType();
    MainIngredient mainIngredient = GetMainIngredient();
    Seasoning seasoning = GetSeasoning();
    return (foodType, mainIngredient, seasoning);
}

FoodType GetFoodType()
{
    Console.WriteLine("Choose food type from soup, stew or gumbo:");
    string passedFood = Console.ReadLine();

    return passedFood switch
    {
        "soup" => FoodType.Soup,
        "stew" => FoodType.Stew,
        "gumbo" => FoodType.Gumbo
    };
}

MainIngredient GetMainIngredient()
{
    Console.WriteLine("Choose main ingredient from mushrooms, chicken, carrots or potatoes:");
    string passedIngredient = Console.ReadLine();

    return passedIngredient switch
    {
        "mushrooms" => MainIngredient.Mushrooms,
        "chicken" => MainIngredient.Chicken,
        "carrots" => MainIngredient.Carrots,
        "potatoes" => MainIngredient.Potatoes
    };
}

Seasoning GetSeasoning()
{
    Console.WriteLine("Choose seasoning from hot, salty or sweet:");
    string passedSeasoning = Console.ReadLine();

    return passedSeasoning switch
    {
        "hot" => Seasoning.Hot,
        "salty" => Seasoning.Salty,
        "sweet" => Seasoning.Sweet
    };
}

enum FoodType { Soup, Stew, Gumbo };
enum MainIngredient { Mushrooms, Chicken, Carrots, Potatoes };
enum Seasoning { Hot, Salty, Sweet };