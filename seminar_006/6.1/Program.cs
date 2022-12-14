// Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами
// такой длины 
// (каждая сторона треугольника меньше суммы двух других сторон)

void Triangle(int a, int b, int c)
{
    if (a < b + c & b < a + c & c < a + b) Console.WriteLine("Треугольник существует");
    else Console.WriteLine("Треугольник не существует");
}
Console.WriteLine("Введите длину сторон треугольника");
Triangle(int.Parse(Console.ReadLine()),
        int.Parse(Console.ReadLine()),
        int.Parse(Console.ReadLine()));
