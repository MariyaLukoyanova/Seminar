// Задайте массив из 12 элементов, заполненный случайными 
// числами из промежутка [-9, 9]. Найдите сумму отрицательных 
// и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] Massiv(int n, int from, int to)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(from, to + 1);
    }
    return array;
}

void Sum(int[] arr)
{
    int pos, neg;
    pos = neg = 0; ;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 0) pos += arr[i];
        else neg += arr[i];
    }
    Console.WriteLine($"Сумма положительных чисел: {pos}");
    Console.WriteLine($"Сумма отрицательных чисел: {neg}");
}

Console.WriteLine("Введите дынне массива: длину, min, max");
int[] array = Massiv(int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine()));
PrintArray(array);
Sum(array);



