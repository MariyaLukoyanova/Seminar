// Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 *x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.



void Crossing(double b1, double k1, double b2, double k2)
{
    if (k1 - k2 != 0)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения прямых: ({x}, {y})");
    }
    else if (k1 == k2 && b1 == b2)
        Console.WriteLine("Прямые совпадают");
    else
        Console.WriteLine("Прямые не пересекаются");
}

Console.WriteLine("Введите b1, k1, b2, k2");
Crossing(int.Parse(Console.ReadLine()),
         int.Parse(Console.ReadLine()),
         int.Parse(Console.ReadLine()),
         int.Parse(Console.ReadLine()));