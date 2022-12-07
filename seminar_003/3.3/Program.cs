// Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу квадратов чисел от 1 до N.


void Sqr(int n)
{
int index = 1;
while (index <= n)
{
    Console.Write($"{index*index}, ");
    index++;
}
}

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
Sqr(N);