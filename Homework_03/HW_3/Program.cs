// Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Sqr(int n)
{
int index = 1;
while (index <= n)
{
    Console.Write($"{Math.Pow(index, 3)}, ");
    index++;
}
}

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
Sqr(N);