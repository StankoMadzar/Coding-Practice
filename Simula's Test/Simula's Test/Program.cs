State Chest = State.Open;
string givenAction = "";

while(true)
{
    if(Chest == State.Open)
    {
        Console.WriteLine("The chest is open. What do you want to do?");
        givenAction = Console.ReadLine();
        if (givenAction != "close")
            continue;
        Chest = State.Closed;
    }

    if (Chest == State.Closed)
    {
        Console.WriteLine("The chest is closed. What do you want to do?");
        givenAction = Console.ReadLine();
        if (givenAction == "unlock" || givenAction == "close")
            continue;
        else if (givenAction == "lock")
            Chest = State.Locked;
        else if (givenAction == "open")
            Chest = State.Open;
    }

    if (Chest == State.Locked)
    {
        Console.WriteLine("The chest is locked. What do you want to do?");
        givenAction = Console.ReadLine();
        if (givenAction != "unlock")
            continue;
        Chest = State.Closed;
    }
}


enum State { Open, Closed, Locked}