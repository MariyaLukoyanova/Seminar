// Задайте двумерный массив. Напишите программу,которая 
// заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

int[,] Massiv(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        {
            for (int j = 0; j < n; j++)
                array[i, j] = new Random().Next(-99, 100);
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

void ChangeRawForColumn(int[,] array)
{
    if (array.GetLength(1) != array.GetLength(0)) Console.WriteLine("Это невозможно!");
    else
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < i; j++)
                (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
        }
}

Console.WriteLine("Введите m*n массива");
int[,] array = Massiv(int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine()));
PrintArray(array);
ChangeRawForColumn(array);
PrintArray(array);