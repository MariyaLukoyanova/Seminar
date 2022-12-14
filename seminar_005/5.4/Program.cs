// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.

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

int[] Couple(int[] array)
{
    int[] arr = new int[array.Length / 2 + array.Length % 2];
    for (int i = 0; i < arr.Length; i++)
    {
        if(i==array.Length - i-1) arr[i]=array[array.Length - i-1];
        else arr[i] = array[i] + array[array.Length - i-1];
    }
    return arr;
}

Console.WriteLine("Введите длину массива");
int[] array = Massiv(int.Parse(Console.ReadLine()));
PrintArray(array);
int[] arr = Couple(array);
PrintArray(arr);