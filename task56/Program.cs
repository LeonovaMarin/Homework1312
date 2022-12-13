// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
///8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка;

int [,] matrix = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}, {5, 2, 6, 7}};
Console.WriteLine("Задан массив:");


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
        Console.WriteLine();
}

Console.WriteLine();


int[] SummaElementsRow(int[,] matrix)
{
    int[] summaElements = new int[matrix.GetLength(0)];
    int summa = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summa += matrix[i, j];
            summaElements[i] = summa;
        }
        summa = 0;
    }
    return summaElements;
}

(int, int) TheSmallestSummaRow(int[] array)
{
    int resultSumma = array[0];
    int resultRow = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < resultSumma)
        {
            resultSumma = array[i];
            resultRow = i;
        }
    }
    return (resultSumma, resultRow);
}

SummaElementsRow(matrix);
int[] summaElementsRow = SummaElementsRow(matrix);
(int, int) theSmallestSummaRow = TheSmallestSummaRow(summaElementsRow);
Console.WriteLine($"Вывод результата вычисления минимальной суммы элементов в строке массива в формате (x, y), где x - это сумма элементов, y - номер строки в массиве:{theSmallestSummaRow}");
Console.WriteLine();