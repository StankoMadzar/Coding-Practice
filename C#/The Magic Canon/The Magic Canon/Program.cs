string attackType = "";

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        attackType = "Combined";
        Console.ForegroundColor = ConsoleColor.Blue;
    }
    else if (i % 5 == 0)
    {
        attackType = "Electric";
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
    else if (i % 3 == 0)
    {
        attackType = "Fire";
        Console.ForegroundColor = ConsoleColor.Red;
    }
    else
    { 
        attackType = "Normal";
        Console.ForegroundColor = ConsoleColor.White;
    } 
    
    Console.WriteLine($"{i}: {attackType}");
}
