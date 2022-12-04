// Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23.

void Krat(int arg)
{
    if ((arg % 7 == 0)&(arg % 23 ==0))
        {Console.WriteLine("Число кратно 7 и 23");}
    else
        {Console.WriteLine("Число не кратно 7 и 23");}
}

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
Krat(num);
