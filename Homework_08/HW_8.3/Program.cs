// Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

int[,] Massiv(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        {
            for (int j = 0; j < n; j++)
                array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],4} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MatrixProduct(int[,] array, int[,] arr)
{
    if (array.GetLength(1) == arr.GetLength(0))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                int productElement = 0;
                for (int k = 0; k < array.GetLength(1); k++)
                    {productElement += array[i, k] * arr[k, j];}
                Console.Write($"{productElement,4} ");
            }
        Console.WriteLine();    
        }  
    }
    else Console.WriteLine("Матрицы не согласованы, вычислить произведение невозможно!");
}


Console.WriteLine("Введите размер первой матрицы");
int[,] array1 = Massiv(int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine()));
Console.WriteLine("Введите размер второй матрицы");
int[,] array2 = Massiv(int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine()));
PrintArray(array1);
PrintArray(array2);
MatrixProduct(array1, array2);

