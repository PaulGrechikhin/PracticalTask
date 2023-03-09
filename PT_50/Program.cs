// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
Console.Clear();

Console.Write("Введите строку массива: ");
int.TryParse(Console.ReadLine()!, out int m);
Console.Write("Введите столбец массива: ");
int.TryParse(Console.ReadLine()!, out int n);

int[,] arr = new int[9, 9];

for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        arr[i, j] = new Random().Next(1, 10);
        Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
}


if (m < 0 || m > 9 || n < 0 || n > 9)
{
    Console.Write("Такого элемента нет");
}
else Console.Write($"{arr[m - 1, n - 1]}");
