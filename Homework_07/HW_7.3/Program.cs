// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце

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

void ArithmeticalMeanColumn(int[,] array)
{
    double sum = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum+=array[i, j];
        }
        Console.Write($"{Math.Round(sum / array.GetLength(0), 2)}; ");
        sum = 0;
    }
}


Console.WriteLine("Введите m*n массива");
int[,] array = Massiv(int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine()));
PrintArray(array);
ArithmeticalMeanColumn(array);