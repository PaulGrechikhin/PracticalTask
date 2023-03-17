//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.


Console.Clear();

Console.Write("Введите число M: ");
int.TryParse(Console.ReadLine()!, out int m);

Console.Write("Введите число N: ");
int.TryParse(Console.ReadLine()!, out int n);

AkkermanFunction(m, n);


void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n));
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}