// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.

int Del2(int arg)
{
    Console.WriteLine(arg);
    arg = (arg / 100) * 10 + (arg % 10);
    return arg; 
}
Console.WriteLine(Del2(new Random().Next(100, 1000)));