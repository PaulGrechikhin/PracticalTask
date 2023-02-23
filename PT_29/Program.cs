// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();

int[] arr = new int[8];

for (int i = 0; i < 8; i++)
{
    arr[i] = new Random().Next(1, 101);
    Console.Write($"{arr[i]}, ");
}