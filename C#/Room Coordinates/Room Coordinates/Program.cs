Coordinate osnovnaTacka = new Coordinate(5, 12);
Coordinate testTacka = new Coordinate(6, 12);

int i = 0;
Random rnd = new Random();

while (i<=10)
{

    int red = rnd.Next(1, 15);
    int kolona = rnd.Next(1, 15);
    Coordinate trenutnaTacka = new Coordinate(red, kolona);

    if (trenutnaTacka.IsAdjacent(osnovnaTacka))
        Console.WriteLine($"trenutna Tacka {trenutnaTacka.Row}, {trenutnaTacka.Column} se dodiruje sa nasom tackom");
    i++;
}

if(testTacka.IsAdjacent(osnovnaTacka))
    Console.WriteLine($"trenutna Tacka {testTacka.Row}, {testTacka.Column} se dodiruje sa nasssom tackom");

public struct Coordinate
{
    public int Row { get; }
    public int Column { get; }

    public Coordinate(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public bool IsAdjacent(Coordinate other)
    {
        if ((this.Row == other.Row + 1)
            || (other.Row == this.Row + 1)
            || (this.Column == other.Column + 1)
            || (other.Column == this.Column + 1))
            return true;
        return false;
    }
}