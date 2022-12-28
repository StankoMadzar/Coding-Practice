using System.Runtime.CompilerServices;
ItemList PonudjeniItemi;
Console.WriteLine("Daj mi kolicinu itema koji moze da stane u torbu");
int numberOfItems = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Daj mi maksimalnu Zapreminu torbe");
float maxVolume = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Daj mi maksimalnu tezinu torbe");
float maxWeight = Convert.ToSingle(Console.ReadLine());

Pack torba = new Pack (numberOfItems, maxVolume, maxWeight);

while (true)
{
    Console.WriteLine("Probaj da ubacis neki item u listu");
    Console.WriteLine("1 - Arrow");
    Console.WriteLine("2 - Bow");
    Console.WriteLine("3 - Rope");
    Console.WriteLine("4 - Water");
    Console.WriteLine("5 - Food");
    Console.WriteLine("6 - Sword");

    int input = Convert.ToInt32(Console.ReadLine());
    InventoryItem newItem = input switch
    {
        1 => new Arrow(),
        2 => new Bow(),
        3 => new Rope(),
        4 => new Water(),
        5 => new Food(),
        6 => new Sword()
    };

    torba.Add(newItem);

    Console.WriteLine($"broj itema: {torba.currentNumberOfItemsInBackpack}/{numberOfItems}");
    Console.WriteLine($"tezina: {torba.currentBackpackWeight}/{torba.MaxWeight}");
    Console.WriteLine($"tezina: {torba.currentBackpackVolume}/{torba.MaxVolume}");
}



public class InventoryItem 
{
    public float Volume { get; }
    public float Weight { get; }

    public InventoryItem(float volume, float weight)
    {
        Volume = volume;
        Weight = weight;
    }
}

public class Arrow : InventoryItem
{
    public Arrow() : base (0.05f, 0.1f)
    {

    }
}

public class Bow : InventoryItem
{
    public Bow() : base (4.0f, 1.0f)
    {

    }
}

public class Rope : InventoryItem
{
    public Rope() : base(1.5f, 1.0f)
    {

    }
}

public class Water : InventoryItem
{
    public Water() : base(3.0f, 2.0f)
    {

    }
}

public class Food : InventoryItem
{
    public Food() : base(0.5f, 1.0f)
    {

    }
}

public class Sword : InventoryItem
{
    public Sword() : base(3.0f, 5.0f)
    {

    }
}

public class Pack
{
    public InventoryItem[] Backpack { get; set; }
    public float MaxVolume { get; set; }
    public float MaxWeight { get; set; }

    public int currentNumberOfItemsInBackpack { get; private set; } = 0;
    public float currentBackpackVolume { get; private set; } = 0.0f;
    public float currentBackpackWeight { get; private set; } = 0.0f;

    public Pack(int numberOfItems, float maxVolume, float maxWeight)
    {
        Backpack = new InventoryItem[numberOfItems];
        MaxVolume = maxVolume;
        MaxWeight = maxWeight;
    }

    public bool Add(InventoryItem item)
    {
        float newVolume = currentBackpackVolume + item.Volume;
        float newWeight = currentBackpackWeight + item.Weight;
        if (newVolume <= MaxVolume && newWeight <= MaxWeight && currentNumberOfItemsInBackpack < Backpack.Length)
        {
            Backpack[currentNumberOfItemsInBackpack] = item;
            currentNumberOfItemsInBackpack++;
            currentBackpackVolume = newVolume;
            currentBackpackWeight = newWeight;
            Console.WriteLine("Uspelo dodavanje");
            return true;
        }
        else
        {
            Console.WriteLine("Neuspelo dodavanje");
            return false;
        }
    }
}

public enum ItemList { Arrow, Bow, Rope, Water, Food, Sword }