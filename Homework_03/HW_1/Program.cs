// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// Решение задачи - конкретно для пятизначного числа.
// void Pal(int arg)
// {
//     if ((arg / 10000 == arg % 10) & (arg / 1000 % 10 == arg % 100 / 10))
//         Console.WriteLine("Это число - палиндром");
//     else
//         Console.WriteLine("Это число - не палиндром");
// }

// Console.WriteLine("Введите пятизначное число");
// int num = int.Parse(Console.ReadLine());
// Pal(num);

// Решение задачи для любого числа
string Pal(int arg, int n)
{
    int i = 1;
    string s = null;
    arg = Math.Abs(arg);
    while (i <= n / 2)
    {
        if (Math.Floor((arg / Math.Pow(10, n - i) % 10)) == Math.Floor((arg % Math.Pow(10, i) / Math.Pow(10, i - 1))))
            {
                i++;
            }
        else
        {
           s = "Это число - не палиндром";
           return s;
        }
    }
    s = "Это число - палиндром";
    return s;    
}

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество цифр в числе");
int N = int.Parse(Console.ReadLine());
Console.WriteLine(Pal(num, N));