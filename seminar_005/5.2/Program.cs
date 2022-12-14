// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
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

string Search(int[] array, int n)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == n)
        {
            return "Число присутсвует";
        }
    }
    return "Число отсутствует";
}

Console.WriteLine("Введите длину массива");
int[] array = Massiv(int.Parse(Console.ReadLine()));
Console.WriteLine("Введите искомое число");
int num = int.Parse(Console.ReadLine());
PrintArray(array);
Console.WriteLine(Search(array, num));
