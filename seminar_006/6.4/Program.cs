// Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования. 

int[,] Massiv(int raw, int column, int from, int to)
{
    int[,] array = new int[raw, column];
    for (int i = 0; i < raw; i++)
    {
        for (int j = 0; j < column; j++)
            array[i, j] = new Random().Next(from, to + 1);
    }
    return array;
}

void PrintArray(int[,] array)
{
    int raw = array.GetLength(0);
    int column = array.GetLength(1);
    for (int i = 0; i < raw; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Copy(int[,] array)
{
    int raw = array.GetLength(0);
    int column = array.GetLength(1);
    int[,] newArr = new int[raw, column];
    for (int i = 0; i < raw; i++)
    {
        for (int j = 0; j < column; j++)
            newArr[i, j] = array[i, j];
    }
    return newArr;
}

Console.WriteLine("Введите данные массива: количество строк, столбцов, начало и конец диапазона");
int[,] array = Massiv(int.Parse(Console.ReadLine()),
                     int.Parse(Console.ReadLine()),
                     int.Parse(Console.ReadLine()),
                     int.Parse(Console.ReadLine()));
PrintArray(array);
int [,] array2 = Copy(array);
PrintArray(array2);