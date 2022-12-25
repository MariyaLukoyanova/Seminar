// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] EnterMassive(string message)
{
    Console.WriteLine(message);
    int[] array = new int[1];
    int i = 0;
    string num;
    while (true)
    {
        num = Console.ReadLine();
        if (num != "")
        {
            Array.Resize(ref array, i + 1);
            array[i] = int.Parse(num);
            i++;
        }
        else return array;
    }
}

int Search(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) count++;
    return count;
}

int[] array = EnterMassive("Введите числа");
PrintArray(array);
Console.WriteLine($"Количество чсиел больше нуля: {Search(array)}");
