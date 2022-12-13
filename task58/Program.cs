// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int [,] matrix1 = {{2, 4}, {3, 2}};

int [,] matrix2 = {{3, 4}, {3, 3}};


void PrintMatrix1(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            if (j < matrix1.GetLength(1) - 1)
                Console.Write($"{matrix1[i, j]} ");
            else Console.Write($"{matrix1[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintMatrix2(int[,] matrix2)
{
    for (int k = 0; k < matrix2.GetLength(0); k++)
    {
        Console.Write("");
        for (int l = 0; l < matrix2.GetLength(1); l++)
        {
            if (l < matrix2.GetLength(1) - 1)
                Console.Write($"{matrix2[k, l]} ");
            else Console.Write($"{matrix2[k, l]} ");
        }
        Console.WriteLine();
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j]} ");
            else Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine();
    }
}
bool CheckMatrix(int[,] matrix1, int[,] matrix2)
{
    return (matrix1.GetLength(1) == matrix2.GetLength(0));
}
int[,] MultiplyTwoMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] multiplyTwoMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (CheckMatrix(matrix1, matrix2) == true)
    {
        for (int i = 0; i < multiplyTwoMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < multiplyTwoMatrix.GetLength(1); j++)
            {
                multiplyTwoMatrix[i, j] = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    multiplyTwoMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
    }
    return multiplyTwoMatrix;
}


Console.WriteLine("Задан массив 1:");
PrintMatrix1(matrix1);
Console.WriteLine("Задан массив 2:");
PrintMatrix2(matrix2);
Console.WriteLine();
Console.WriteLine(@CheckMatrix(matrix1, matrix2) ? "Произведение двух матриц (массив 1 * массив 2)"
: "Условия не соблюдаются, умножение невозможно");
int[,] multiplyTwoMatrix = MultiplyTwoMatrix(matrix1, matrix2);
PrintMatrix(multiplyTwoMatrix);
Console.WriteLine();