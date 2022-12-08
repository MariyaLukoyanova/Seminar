// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.

int Prod(int num)
{
    if (num == 0) return 0;
    int prod = 1;
    for (int i = 1; i <= num; i++)
    {
        prod = prod * i;
    }
    return prod;
}
Console.WriteLine("Введите число");
Console.WriteLine(Prod(int.Parse(Console.ReadLine())));