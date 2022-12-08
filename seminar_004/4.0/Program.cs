// Напишите программу, которая принимает
// на вход число (А) и выдаёт сумму чисел от 1 до А.

int Sum(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}
Console.WriteLine("Введите число");
Console.WriteLine(Sum(int.Parse(Console.ReadLine())));