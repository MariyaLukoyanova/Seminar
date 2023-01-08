// Задайте значения M и N. Напишите программу, которая выведет все
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.

void FromMtoN(int m, int n)
{
    if (m > n) return;
    if ((m > 0) && (m % 2 == 0)) Console.Write($"{m}, ");
    FromMtoN(m + 1, n);
}



Console.WriteLine("Enter M & N");
FromMtoN(int.Parse(Console.ReadLine()),
int.Parse(Console.ReadLine()));