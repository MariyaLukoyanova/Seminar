// Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

double[] Massiv(int n)
{
    double[] array = new double[n];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (100 - (-100)) + (-100), 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void Search(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"Разница между максимальным и минимальном числами массива: {Math.Round((max - min), 2)}");
}

Console.WriteLine("Введите длину массива");
double[] array = Massiv(int.Parse(Console.ReadLine()));
PrintArray(array);
Search(array);