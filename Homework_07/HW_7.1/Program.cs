// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.


double[,] Massiv(int m, int n)
{
    double[,] array = new double[m, n];
    Random rnd = new Random();
     for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        array[i, j] = Math.Round(rnd.NextDouble() * (100 - (-100)) + (-100), 1);
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],6} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Введите m*n массива");
double[,] array = Massiv(int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine()));
PrintArray(array);
