// Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

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

void DescendingRaw(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int m = 0; m < array.GetLength(1); m++)
        {
            for (int j = m; j < array.GetLength(1); j++)
                if (array[i, j] > array[i, m]) (array[i, m], array[i, j]) = (array[i, j], array[i, m]);
        }
    }
}


Console.WriteLine("Введите количество строк и столбцов массива");
int[,] array = Massiv(int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine()));
PrintArray(array);
DescendingRaw(array);
PrintArray(array);