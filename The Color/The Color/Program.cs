Color FirstColor = new Color(129, 223, 49);
Color SecondColor = Color.Orange;

Console.WriteLine($"R={FirstColor.R} G={FirstColor.G} B={FirstColor.B}");
Console.WriteLine($"R={SecondColor.R} G={SecondColor.G} B={SecondColor.B}");

class Color
{
    public byte R { get; set; }
    public byte G { get; set; }
    public byte B { get; set; }

    //Common Colors
    public static Color White   { get; } = new Color(255, 255, 255);
    public static Color Black   { get; } = new Color(255, 255, 255);
    public static Color Red     { get; } = new Color(255,   0,   0);
    public static Color Orange  { get; } = new Color(255, 165,   0);
    public static Color Yellow  { get; } = new Color(255, 255,   0);
    public static Color Green   { get; } = new Color(  0,   0, 255);
    public static Color Purple  { get; } = new Color(128,   0, 128);

    public Color (byte red, byte green, byte blue)
    {
        R = red;
        G = green;
        B = blue;
    }
}