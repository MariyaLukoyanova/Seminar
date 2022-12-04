// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру 
// этого числа.



int Num(int arg)
{while(arg < 100 || arg > 999)
    {
        Console.WriteLine("Число не трехзначное!");
        Console.WriteLine("Введите трехзначное число");
        arg = int.Parse(Console.ReadLine());
    }
        return arg;
}

Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Вторая цифра в числе {(Num(num)%100)/10}");
