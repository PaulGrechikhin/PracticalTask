// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

Console.Write("Введите кол-во строк: ");
int.TryParse(Console.ReadLine()!, out int m);
Console.Write("Введите кол-во столбцов: ");
int.TryParse(Console.ReadLine()!, out int n);

int[,] arr = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = new Random().Next(1, 10);
        Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
}

for (int i = 0; i < m; i++)
{
    double count = 0;
    for (int j = 0; j < n; j++)
    {
        count += arr[i, j];
        count /= m;
    }
    Console.Write($"{count} ");
}