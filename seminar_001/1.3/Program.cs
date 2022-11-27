// На вход принимает число N, 
// на выход показывает все целые число в промежутке от -N до N

Console.WriteLine("Введите число N ");
int N = int.Parse(Console.ReadLine());
int count = - N;
while(count <= N)
{
    Console.Write($"{count}, ");
    count = count + 1;
}