// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.


int FromMtoN(int m, int n)
{
    if (m > n) return 0;
    return m + FromMtoN(m + 1, n);
}



Console.WriteLine("Enter M & N");
Console.WriteLine(FromMtoN(int.Parse(Console.ReadLine()),
int.Parse(Console.ReadLine())));