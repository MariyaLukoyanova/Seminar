// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними
// в 2D пространстве.
int ReadNumber(string message) 
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = (s == null) ? 0 : int.Parse(s);
    return a;
}


double Distance(int ax, int ay, int bx, int by)
{
    double result;
    result = Math.Sqrt(Math.Pow(bx-ax, 2)+Math.Pow(by-ay, 2));
    return result;
}

int ax = ReadNumber("Введите X первой точки: ");
int ay = ReadNumber("Введите Y первой точки: ");
int bx = ReadNumber("Введите X второй точки: ");
int by = ReadNumber("Введите Y второй точки: ");

Console.WriteLine(Math.Round(Distance(ax, ay, bx, by), 2));


