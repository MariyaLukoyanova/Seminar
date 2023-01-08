// Задайте значения M и N. Напишите программу, которая
// рекурсивно выведет все натуральные числа в промежутке от M до N.

void CreateFromMtoN(int m, int n)
{
    if (m > n) return;
    Console.Write($"{m}, ");
    CreateFromMtoN(m + 1, n);
}



Console.WriteLine("Enter M & N");
CreateFromMtoN(int.Parse(Console.ReadLine()),
int.Parse(Console.ReadLine()));