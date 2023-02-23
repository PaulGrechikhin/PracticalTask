//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

Console.Clear();

Console.Write("Введите два числа: ");
int.TryParse(Console.ReadLine()!, out int A);
int.TryParse(Console.ReadLine()!, out int B);
int a = A;

for (int i = 2; i <= B; i++)
{
    A *= a;
}
Console.Write(A);