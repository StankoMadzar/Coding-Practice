int manticoreDistance;
int consolasHP = 15;
int manticoreHP = 10;
int roundNumber = 1;

Console.WriteLine("Player 1, how far away from the city do you want to station the Manticore?");
manticoreDistance = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("Player 2, it is your turn.");

while(true)
{
    Console.WriteLine("------------------------------------------------------");
    Console.WriteLine($"Status: Round: {roundNumber} City: {consolasHP}/15 Manticore {manticoreHP}/10");
    Console.WriteLine($"The canon is expected to deal {CalculateCannonDamage()} damage this round");
    Console.WriteLine("Enter desired cannon range:");
    int distanceToCheck = Convert.ToInt32(Console.ReadLine());
    if (distanceToCheck < manticoreDistance)
        Console.WriteLine("That Round FELL SHORT of the target");
    else if (distanceToCheck > manticoreDistance)
        Console.WriteLine("That round OVERSHOT the target");
    else
    {
        Console.WriteLine("That round was a DIRECT HIT");
        manticoreHP -= ReduceHealthpointsBasedOn(roundNumber);
    }

    consolasHP--;
    roundNumber++;

    if (manticoreHP <= 0)
    {
        Console.WriteLine("The Manticore has been defeated, the city of Consolas has been saved");
        break;
    }
    else if (consolasHP <= 0)
    {
        Console.WriteLine("The Manticore has destroyed Consolas, oh the humanity!");
        break;
    }
}

int ReduceHealthpointsBasedOn(int roundNumber)
{
    if (roundNumber % 3 == 0 && roundNumber % 5 == 0)
        return 10;
    else if (roundNumber % 3 == 0 || roundNumber % 5 == 0)
        return 3;
    else
        return 1;

}

string CalculateCannonDamage()
{
    if (roundNumber % 3 == 0 && roundNumber % 5 == 0)
        return Convert.ToString(10);
    else if (roundNumber % 3 == 0 || roundNumber % 5 == 0)
        return Convert.ToString(3);
    else
        return Convert.ToString(1);
}