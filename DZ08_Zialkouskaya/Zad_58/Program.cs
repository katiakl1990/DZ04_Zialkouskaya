// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

bool IsMatricesMultiplayable(int[,] matrixA, int[,] matrixB)
{
    return matrixA.GetLength(1) == matrixB.GetLength(0);
}

int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
{
  
    int[,] resultMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int l = 0; l < resultMatrix.GetLength(0); l++)  
    {
        for (int n = 0; n < resultMatrix.GetLength(1); n++)
        {
            for (int m = 0; m < matrixA.GetLength(1); m++)  
            {
                resultMatrix[l, n] += matrixA[l, m] * matrixB[m, n];
            }
        }
    }
    return resultMatrix;
}

int[,] matrixA = new int[,]
{
    {2, 4},
    {3, 2},
};

int[,] matrixB = new int[,]
{
    {3, 4},
    {3, 3},
};
Console.Clear();
PrintArray(matrixA);
Console.WriteLine("Помножить на");
PrintArray(matrixB);
Console.WriteLine("Равно");

if (IsMatricesMultiplayable(matrixA, matrixB))
{
    int[,] resultMatrix = MultiplyMatrices(matrixA, matrixB);
    PrintArray(resultMatrix);
}
else Console.WriteLine("Матрицы нельзя перемножить");
