﻿Console.Clear();

//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

double a, b;

Console.Write("Введите первое число: ");
double.TryParse(Console.ReadLine()!, out a);

Console.Write("Введите второе число: ");
double.TryParse(Console.ReadLine()!, out b);

//double a = double.Parse(text1);
//double b = double.Parse(text2);


if(a>b)
{
    Console.Write(a + " > " + b);
}
else
{
    Console.Write(a + " < " + b);
}