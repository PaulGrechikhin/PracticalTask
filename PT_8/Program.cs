Console.Clear();

//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int number;
Console.Write("Введите натуральное число: ");
int.TryParse(Console.ReadLine()!, out number);

int[] Array = new int[number];
int index = 0, count = 1;

while (index < number)
{
    Array[index] = count;
    if (Array[index]%2 == 0)
    {
        Console.Write($"{Array[index]}, ");
    }
    count++;
    index++;
}