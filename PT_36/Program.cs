//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

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
            Array[i] = new Random().Next(-99, 100);
            Console.WriteLine(Array[i]);
            if (i % 2 != 0)
                count += Array[i];
        }
        Console.Write($"Сумма чиссел на нечетных позициях массива: {count}");
        return Array;
    }
}
else
    Console.Write("Неверный ввод");