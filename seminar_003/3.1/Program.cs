// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

void Quarters(string arg)
{
    if(arg == "I") 
        Console.WriteLine("x > 0, y > 0");
    else if(arg == "II")
        Console.WriteLine("x < 0, y > 0");
    else if(arg == "III")
        Console.WriteLine("x < 0, y < 0");
    else if(arg == "IV")
        Console.WriteLine("x > 0, y < 0");
    else
    Console.WriteLine("Такой четверти не существует");
}
Console.WriteLine("Введите номер четверти");
Quarters(Console.ReadLine());