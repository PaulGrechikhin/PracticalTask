Console.Clear();

//Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

int number;
Console.Write("Введите целое число: ");
int.TryParse(Console.ReadLine()!, out number);

if(number % 2 == 0 )
{
    Console.Write("Число четное");
}
else
{
    Console.Write("Число нечетное");
}