// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.


void Num3(int arg)
{if ((arg < 100 & arg > -100) || arg > 999 || arg <-999)
    {
        Console.WriteLine("Третьей цифры нет!");
    }
    else 
    {
        Console.WriteLine($"Третья цифра {Math.Abs(arg % 10)}");
    }
}
Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
Num3(num);

