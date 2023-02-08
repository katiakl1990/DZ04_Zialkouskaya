// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double RandomDouble(int minBorder, int maxBorder)  
{
    double randomDouble = new Random().NextDouble() * (maxBorder - minBorder) + minBorder;
    return randomDouble;
}

double[,] GetDoubleMatrix(int m, int n, int minBorder, int maxBorder)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = RandomDouble(minBorder, maxBorder);
        }
    }
    return matrix;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f3}\t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
double[,] matr = GetDoubleMatrix(m: 4, n: 5, minBorder: 10, maxBorder: 90);
PrintArray(matr);