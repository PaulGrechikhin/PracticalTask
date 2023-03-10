//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();

int[,] array_1 = new int[2, 2];
int[,] array_2 = new int[2, 2];

FillArray(array_1);
FillArray(array_2);
PrintArray(array_1);
PrintArray(array_1);

int[,] array = new int[array_1.GetLength(0), array_2.GetLength(1)];

if (array_1.GetLength(1) == array_2.GetLength(0))
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = 0;
            for (int n = 0; n < array_1.GetLength(1); n++)
            {
                array[i, j] += array_1[i, n] * array_2[n, j];
            }
        }
    }
}

PrintArray(array);

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] FillArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(1, 10);
        }
    }
    return Array;
}