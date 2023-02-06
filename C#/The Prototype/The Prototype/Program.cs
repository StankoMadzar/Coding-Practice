int number;
int attemptCount = 0;

do
{
    if(attemptCount == 0) 
    Console.WriteLine("User 1, give me a number between 0 and 100");
    number = Convert.ToInt32(Console.ReadLine());
    if (number < 0 || number > 100)
        Console.WriteLine("I said between 0 and 100!");
    attemptCount++;
}
while (number < 0 || number > 100);
Console.Clear();
Console.WriteLine("User 2, guess the number");

while(true)
{
    Console.Write("What is your next guess? ");
    int guess = Convert.ToInt32(Console.ReadLine());

    if (guess > number)
        Console.WriteLine($"{guess} is too high!");
    else if (guess < number)
        Console.WriteLine($"{guess} is to low!");
    else
        break;
}

Console.WriteLine("You guessed the number!");