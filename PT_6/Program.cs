Console.Clear();

//Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

int number;
Console.Write("Введите натурольное число: ");
int.TryParse(Console.ReadLine()!, out number);

int remains = number % 2;

if(remains == 0 )
{
    Console.Write("Число четное");
}
else
{
    Console.Write("Число нечетное");
}