// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

void Weekend(int arg)
{
    if(arg < 1 || arg > 7)
    {Console.WriteLine("Такого дня не существует :/");}
    else
    {
        if (arg == 6 || arg == 7)
            Console.WriteLine("Это выходной :)");
        else
            Console.WriteLine("Это не выходной :(");
    }
}
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
Weekend(num);