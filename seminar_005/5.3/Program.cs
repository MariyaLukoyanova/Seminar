// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99]. 
int[] Massiv(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int Search(int[] array, int from, int to)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > from & array[i] < to)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите длину массива");
int[] array = Massiv(int.Parse(Console.ReadLine()));
Console.WriteLine("Введите границы поиска");
Console.WriteLine(Search(array, int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
PrintArray(array);

