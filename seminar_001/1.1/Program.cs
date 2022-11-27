// На вход принимает два числа и проверяет, 
//является ли первое число квадратом второго.

Console.WriteLine("Введине первое число ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введине второе число ");
int b = int.Parse(Console.ReadLine());

if(a == b*b)
{
    Console.WriteLine("Является");
}
else
    Console.WriteLine("Не является");