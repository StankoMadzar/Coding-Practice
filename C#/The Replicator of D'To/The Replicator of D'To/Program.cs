using System.Diagnostics.Contracts;
using System.Globalization;

int[] original = new int[5];

for (int item = 0; item < 5; item++)
{
    int number = Convert.ToInt32(Console.ReadLine());
    original[item] = number; 
}

int[] copy = new int[5];

for (int index = 0; index<5; index++)
{
    copy[index] = original[index];
}

for (int index = 0; index < 5; index++)
    Console.WriteLine($"original {original[index]}, copy {copy[index]}");