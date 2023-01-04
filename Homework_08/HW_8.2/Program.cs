// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

int[,] Massiv(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        {
            for (int j = 0; j < n; j++)
                array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],4} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MinSumRaw(int[,] array)
{
    int sum1 = 0;
    int raw = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    { sum1 += array[0, j]; }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum2 = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum2 += array[i, j];
        }
        if (sum2 < sum1) { sum1 = sum2; raw = i; }
    }
    Console.WriteLine($"Наименьшая сумма элементов в строке {raw + 1}");
}

Console.WriteLine("Введите m*n массива");
int[,] array = Massiv(int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine()));
PrintArray(array);
MinSumRaw(array);

