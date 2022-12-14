// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)

int[] Massiv(int n, int from, int to)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(from, to + 1);
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

int[] ChangeArray(int[] array)
{
    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
    {
        // int num = array[i];
        // array[i] = array[array.Length - i - 1];
        // array[array.Length - i - 1] = num;
        (array[i], array[array.Length - i - 1]) = (array[array.Length - i - 1], array[i]);
        // левая часть слева - принимающая, правая - отдающая
    }
    return array;
}


Console.WriteLine("Введите данные массива: длину, начало и конец диапазона");
int[] array = Massiv(int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine()));
PrintArray(array);
PrintArray(ChangeArray(array));