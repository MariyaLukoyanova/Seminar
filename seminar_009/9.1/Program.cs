// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N при помощи рекурсии.


void CreateN(int n)
{
    if (n == 0) return;
        CreateN(n - 1);
        Console.Write($"{n}, ");
}



Console.WriteLine("Enter N");
CreateN(int.Parse(Console.ReadLine()));
