// Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.

int Num(int arg)
{
    arg = Math.Abs(arg);
    if (arg == 0) return 0;
    int count = 0;
    while (arg > 0)
    {
        count = count + arg % 10;
        arg = arg / 10;
    }
    return count;
}

Console.WriteLine("Введите число");
Console.WriteLine(Num(int.Parse(Console.ReadLine())));