// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
int[,] array = new int[4, 2];

FillArray(array);
PrintArray(array);

int[] arr = new int[array.GetLength(0)];

for (int i = 0; i < array.GetLength(0); i++)
{
    int count = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        count += array[i, j];
        arr[i] = count;
    }
    count = 0;
}

int min = arr[0];
int N = 0;
for (int i = 1; i < arr.Length; i++)
{
    if (min > arr[i])
    {
        min = arr[i];
        N = i + 1;
    }
}
Console.Write($"Минимальная сумма в строке {N} равна: {min}");

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