// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр. Использовать рекурсию.

int SumDigit(int n)
{
    if (n == 0) return 0;
    return SumDigit(n / 10) + n % 10;
}



Console.WriteLine("Enter N");
Console.WriteLine(SumDigit(int.Parse(Console.ReadLine())));