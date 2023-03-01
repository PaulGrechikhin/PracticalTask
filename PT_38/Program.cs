//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

Console.Write("Задайте длину массива: ");
bool flag = int.TryParse(Console.ReadLine()!, out int N);


if (flag)
{

    double[] array = CreateArray(N);





    double[] CreateArray(int _n)
    {
        double[] Array = new double[_n];

        int i;
        for (i = 0; i < _n; i++)
        {
            Array[i] = new Random().Next(0, 100);
            Console.WriteLine(Array[i]);
        }
        double max = Array[0];
        double min = Array[0];
        for (i = 0; i < _n; i++)
        {
            if (max < Array[i])
                max = Array[i];
            if (min > Array[i])
                min = Array[i];
        }

        Console.WriteLine();
        Console.WriteLine(min);
        Console.WriteLine(max);
        Console.Write($"Разница между максимальным и минимальным элементами: {max - min}");
        return Array;
    }
}
else
    Console.Write("Неверный ввод");