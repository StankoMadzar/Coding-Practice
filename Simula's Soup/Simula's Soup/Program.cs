(SoupType type, MainIngredient ingredient, Seasoning seasoning) soup = GetSoup();
Console.WriteLine($"You have chosen {soup.seasoning} {soup.ingredient} {soup.type}");

(SoupType, MainIngredient, Seasoning) GetSoup()
{
    SoupType type = GetSoupType();
    MainIngredient ingredient = GetMainIngredient();
    Seasoning seasoning = GetSeasoning();
    return (type, ingredient, seasoning);
}

Seasoning GetSeasoning()
{
    Console.WriteLine("You can chose from: Spicy, Salty, Sweet");
    string input = Console.ReadLine().ToLower();
    return input switch
    {
        "spicy" => Seasoning.Spicy,
        "salty" => Seasoning.Salty,
        "sweet" => Seasoning.Sweet
    };
}

MainIngredient GetMainIngredient()
{
    Console.WriteLine("You can chose from: Mushroom, Chicken, Carrot, Potato");
    string input = Console.ReadLine().ToLower(); ;
    return input switch
    {
        "mushroom" => MainIngredient.Mushroom,
        "chicken" => MainIngredient.Chicken,
        "carrot" => MainIngredient.Carrot,
        "potato" => MainIngredient.Potato
    };

}

SoupType GetSoupType()
{
    Console.WriteLine("You can chose from: Soup, Stew, Gumbo");
    string input = Console.ReadLine().ToLower();
    return input switch
    {
        "soup" => SoupType.Soup,
        "stew" => SoupType.Stew,
        "gumbo" => SoupType.Gumbo,
    };
}
enum SoupType { Soup, Stew, Gumbo }
enum MainIngredient { Mushroom, Chicken, Carrot, Potato }
enum Seasoning { Spicy, Salty, Sweet }