// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();

int Round(int n)
{
    int[] Array = new int[Convert.ToString(n).Length];
    int i, length = Array.Length;
    for (i = 0; i < length; i++)
    {
        Array[i] = n % 10;
        n /= 10;
    }

    int length2 = length / 2 - 1;
    int i2 = length2 - 1;
    for (i = 0; i < length2; i++, i2--)
    {
        int temp = Array[i];
        Array[i] = Array[i2];
        Array[i2] = temp;
    }
    string String = $"{Array[0]}{Array[1]}{Array[2]}{Array[3]}{Array[4]}";
    int.TryParse(String, out n);
    return n;
}

Console.Write("Введите пятизначное натуральное число: ");
bool flag = int.TryParse(Console.ReadLine()!, out int n);

if (flag)
{
    if (n == Round(n))
        Console.Write("Число - палиндром");
    else
        Console.Write("Число - не является палиндромом");
}
else
{
    Console.Write("Неверный ввод");
}