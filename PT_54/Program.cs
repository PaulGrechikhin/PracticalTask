// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
//каждой строки двумерного массива.


Console.Clear();

int[,] arr = new int[5, 5];
FillArray(arr);
PrintArray(arr);
SortArray(arr);
PrintArray(arr);



int[,] SortArray(int[,] Array)
{

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {

            for (int c = j + 1; c < Array.GetLength(1); c++)
            {
                int temp;
                if (Array[i, j] < Array[i, c])
                {
                    temp = Array[i, j];
                    Array[i, j] = Array[i, c];
                    Array[i, c] = temp;
                }
            }
        }
    }
    return Array;
}

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