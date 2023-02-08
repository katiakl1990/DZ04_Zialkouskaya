// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] GetRandomMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void GetMatrixCell(int[,] matrix)  
{
    Console.Write("Введите строку: ");
    int row = int.Parse(Console.ReadLine()!);
    if (row >= matrix.GetLength(0)) Console.WriteLine("такого числа в массиве нет");
    else
    {
        Console.Write("Введите столбец: ");
        int column = int.Parse(Console.ReadLine()!);
        if (column >= matrix.GetLength(1)) Console.WriteLine("такого числа в массиве нет");
        else Console.WriteLine(matrix[row, column]);
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int[,] matr = GetRandomMatrix(m: 4, n: 5, minValue: 10, maxValue: 90);
PrintArray(matr);
GetMatrixCell(matr);