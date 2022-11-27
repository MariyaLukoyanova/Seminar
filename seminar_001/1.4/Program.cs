// Вычисление модуля числа

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());

if(N < 0)
{
    N = - N;
}
Console.WriteLine(N);