//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

Console.Write("Задайте длину массива: ");
bool flag = int.TryParse(Console.ReadLine()!, out int N);


if (flag)
{

    int[] array = CreateArray(N);

    int[] CreateArray(int _n)
    {
        int[] Array = new int[_n];
        int count = 0;
        for (int i = 0; i < _n; i++)
        {
            Array[i] = new Random().Next(100, 1000);
            Console.WriteLine(Array[i]);
            if (Array[i] % 2 == 0)
                count++;
        }
        Console.Write($"Колличесвто четных чисел: {count}");
        return Array;
    }
}
else
    Console.Write("Неверный ввод");