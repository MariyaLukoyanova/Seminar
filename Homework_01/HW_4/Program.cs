// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());

if(num <=0)
{
    Console.WriteLine("Ошибка ввода - только положительные числа!");
}
int count = 1;
while (count <= num)
{
    if(count % 2 == 0)
    {
        Console.Write($"{count}, ");
    }
count++;
}

