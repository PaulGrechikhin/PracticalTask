// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();

Console.Write("Введите кол-во строк: ");
int.TryParse(Console.ReadLine()!, out int m);
Console.Write("Введите кол-во столбцов: ");
int.TryParse(Console.ReadLine()!, out int n);

double[,] arr = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = new Random().NextDouble();
        Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
}