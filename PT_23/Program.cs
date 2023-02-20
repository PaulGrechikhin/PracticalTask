//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

int number;
Console.Write("Введите натуральное число: ");
int.TryParse(Console.ReadLine()!, out number);

int[] Array = new int[number];
int index = 0, count = 1;

while (index < number)
{
    Array[index] = count;
    Console.Write($"{(double)Math.Pow(Array[index], 3)}, ");
    index++;
    count++;
}