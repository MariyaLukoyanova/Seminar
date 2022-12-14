// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.

string Transform(int num)
{
    string result = null;
    while (num > 0)
    {
        result = num % 2 + result;
        num = num / 2;
    }
    return result;
}

Console.WriteLine("Введите число");
Console.WriteLine(Transform(int.Parse(Console.ReadLine())));