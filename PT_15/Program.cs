Console.Clear();

// Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число:");
bool flag = int.TryParse(Console.ReadLine()!, out int number);

if (flag && number > 0 && number < 8)
{

    if (number > 5 && number < 8)
        Console.WriteLine("Выходной");
    else
        Console.WriteLine("Работаем");
}
else
    Console.WriteLine("Введите число от 1 до 7");