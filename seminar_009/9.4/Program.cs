// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.

int Degree(int a, int b)
{
    if (b == 0) return 1;
    return a * Degree(a, b - 1);
}



Console.WriteLine("Enter A & B");
Console.WriteLine(Degree(int.Parse(Console.ReadLine()),
int.Parse(Console.ReadLine())));
