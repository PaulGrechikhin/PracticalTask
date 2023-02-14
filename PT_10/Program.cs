Console.Clear();

//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int number;
Console.Write("Введите трехзначное число: ");
bool flag = int.TryParse(Console.ReadLine()!, out number);

if (flag)
{
    if (number > 100 && number < 1000) number = number / 10 % 10;
    else Console.Write("Число не трехзначное: ");
    Console.Write(number);
}
else Console.Write("Неверный ввод");