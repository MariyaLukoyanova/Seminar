// Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие
// отрицательные, и наоборот.
int[] Massiv(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(-99, 100);
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

void Change(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i]=array[i]*-1;
    }
}

Console.WriteLine("Введите длину массива");
int[] array = Massiv(int.Parse(Console.ReadLine()));
PrintArray(array);
Change(array);
PrintArray(array);