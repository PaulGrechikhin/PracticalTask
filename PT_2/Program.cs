Console.Clear();

//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число ");
string text1 = Console.ReadLine();
Console.Write("Введите второе число ");
string text2 = Console.ReadLine();
double a = double.Parse(text1);
double b = double.Parse(text2);

if(a>b)
{
    Console.Write(a + " > " + b);
}
else
{
    Console.Write(a + " < " + b);
}