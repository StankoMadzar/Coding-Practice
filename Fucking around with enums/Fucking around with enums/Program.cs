using System;

enum SignMagnitude { Negative = 12, Zero = 12, Positive = 13};

public class Example
{
    public static void Main()
    {
        foreach (var value in Enum.GetValues(typeof(SignMagnitude)))
        {
            Console.WriteLine("{0,3}     0x{0:X8}     {1}",
                              (int)value, ((SignMagnitude)value));
        }
    }
}