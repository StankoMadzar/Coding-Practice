int number = 10;

FinalCountdown(number);


void FinalCountdown(int number)
{
    if (number == 0) return;
    Console.WriteLine(number);
    FinalCountdown(number - 1);
}