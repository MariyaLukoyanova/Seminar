// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

void Fib(int N)
{
    int n1 = 0, n2 = 1;
    for (int i = 0; i < N; i++)
    {
        Console.Write($"{n1} ");
        (n1, n2) = (n2, n1 + n2);
    }
}
Console.WriteLine("Введите число");
Fib(int.Parse(Console.ReadLine()));