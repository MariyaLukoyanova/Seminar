// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз 
// встречается элемент входных данных. Значения элементов массива 0..9

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

void PrintMassive(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.WriteLine($"{i} встречается: {arr[i]}");
    Console.WriteLine();
}

int[] FrequencyDict(int[,] array)
{
    int[] freq = new int[10];
    foreach (int item in array)
        freq[item] += 1;
    return freq;
}
// цикл foreach перебирает все элементы двумерного массива
// item принимает значение числа из двумерного массива
// в одномерном массиве - счетчики, индекс которых = item
// например число 1 в двумерном массиве встречается 5 рах = 
// = его счетчик будет равен 5 и находится в одномерном массиве под индексом 1

Console.WriteLine("Введите m*n массива");
int[,] array = Massiv(int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine()));
PrintArray(array);
PrintMassive(FrequencyDict(array));
