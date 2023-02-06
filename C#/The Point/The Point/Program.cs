
Point FirstPoint = new Point(2, 3);
Point SecondPoint = new Point(-4, 0);
Point ThirdPoint = new Point();

Console.WriteLine($"The points are {(FirstPoint.X, FirstPoint.Y)} and {(SecondPoint.X, SecondPoint.Y)}");
Console.WriteLine($"Checking the parameterless constructor {(ThirdPoint.X, ThirdPoint.Y)}");

public class Point
{
    public float X { get; }
    public float Y { get; }

    public Point(float x, float y)
    {
        X = x;
        Y = y;
    }

    public Point()
    {
        X = 0;
        Y = 0;
    }
}
