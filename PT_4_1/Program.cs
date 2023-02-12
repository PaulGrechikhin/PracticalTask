Console.Clear();

//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

double a, b, c;

Console.Write("Введите первое число: ");
double.TryParse(Console.ReadLine()!, out a);
Console.Write("Введите первое число: ");
double.TryParse(Console.ReadLine()!, out b);
Console.Write("Введите первое число: ");
double.TryParse(Console.ReadLine()!, out c);
 
double max = a;

if(a > b){}
else
    max = b;

if(b > c){}
else
    max = c;

Console.Write($"max = {max}");