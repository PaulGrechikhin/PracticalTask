// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();

Console.Write("Введите натуральное число: ");
bool flag = int.TryParse(Console.ReadLine()!, out int number);

if (flag)
{
    int count = 0;
    while (number > 0)
    {
        int num = number % 10;
        number /= 10;
        count = count + num;
    }
    Console.Write(count);
}
else
    Console.Write("Неверный ввод");