Console.WriteLine("Give me a starting numeric Passcode for a door");
int startingPasscode = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Door FirstDoor = new Door(startingPasscode);

while(true)
{
    Console.WriteLine($"The door is now {FirstDoor.State}");
    string? input = Console.ReadLine().ToLower();
    if (input == "lock") FirstDoor.LockDoor();
    if (input == "open") FirstDoor.OpenDoor();
    if (input == "close") FirstDoor.CloseDoor();
    if (input == "unlock") FirstDoor.UnlockDoor();
    if (input == "change passcode") FirstDoor.ChangePasscode();
}

public class Door
{
    private int Passcode { get; set; }
    public DoorStatus State { get; private set; } = DoorStatus.Open;

    public Door(int startingPasscode)
    {
        Passcode = startingPasscode;
    }

    public void ChangePasscode()
    {
        Console.WriteLine("Give me the old passcode first");
        int offeredPasscode = Convert.ToInt32(Console.ReadLine());
        if (Passcode != offeredPasscode)
        {
            Console.WriteLine("Wrong Passcode, Change denied");
            return;
        }
        else
        {
            Console.WriteLine("Give me new password");
            int newPasscode = Convert.ToInt32(Console.ReadLine());
            Passcode = newPasscode;
            Console.Clear();
            Console.WriteLine("Password changed succesfully");
        }
    }

    public void UnlockDoor()
    {
        if (State != DoorStatus.Locked)
        {
            Console.WriteLine("You can't do that now");
            return;
        }
        
        Console.WriteLine("Give me the Passcode pls");
        int PasscodeOffered = Convert.ToInt32(Console.ReadLine());
        if (PasscodeOffered == Passcode && State == DoorStatus.Locked)
        {
            State = DoorStatus.Closed;
        }
        else Console.WriteLine("Wrong passcode!");
    }
    public void LockDoor()
    {
        if (State == DoorStatus.Closed)
        {
            State = DoorStatus.Locked;
        }
        else
            Console.WriteLine("You can't do that now");
    }
    public void OpenDoor()
    {
        if (State == DoorStatus.Closed)
        {
            State = DoorStatus.Open;
        }
        else
            Console.WriteLine("You can't do that now");
    }

    public void CloseDoor()
    {
        if (State == DoorStatus.Open)
        {
            State = DoorStatus.Closed;
        }
        else 
            Console.WriteLine("You can't do that now");

    }
}

public enum DoorStatus { Open, Closed, Locked }