// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.

int Num(int arg)
{
    arg = Math.Abs(arg);
    if (arg == 0) return 1;
    int count = 0;
    while (arg > 0)
    {
        arg = arg / 10;
        count++;
    }
    return count;
}

Console.WriteLine("Введите число");
Console.WriteLine(Num(int.Parse(Console.ReadLine())));