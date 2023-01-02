// Напишите программу, которая на вход принимает позиции 
// элемента  в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

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

string SearchNum(int[,] array, int raw, int column)
{
    if (raw-1 < 0 | raw-1 > array.GetLength(0) | column-1 < 0 | column-1 > array.GetLength(1)) return "Такого элемента не существует в данном массиве";
    else return $"Значение элемента: {array[raw-1, column-1]}";
}


Console.WriteLine("Введите m*n массива");
int[,] array = Massiv(int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine()));
PrintArray(array);
Console.WriteLine("Введите позицию элемента");
Console.WriteLine(SearchNum(array, 
int.Parse(Console.ReadLine()),
int.Parse(Console.ReadLine())));