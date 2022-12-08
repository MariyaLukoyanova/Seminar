//  Напишите цикл, который принимает на вход два числа 
//  (A и B) и возводит число A в натуральную степень B.


int ReadNumber(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = (s == null) ? 0 : int.Parse(s);
    return a;
}

double Power(int a, int b)
{
    if (a == 0) return 0;
    if (b == 0) return 1;
    double pow = 1;
    for (int i = 1; i <= Math.Abs(b); i++)
    {
        if (b > 0) pow = pow * a;
        if (b < 0) pow = pow / a;
    }
    return pow;
}

int A = ReadNumber("Введите число А ");
int B = ReadNumber("Введите число B ");
Console.WriteLine(Power(A, B));