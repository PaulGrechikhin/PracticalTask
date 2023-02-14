Console.Clear();

int ConOutThreeNum(int number)
{
    while (number > 999)
        number /= 10;
    return number %= 10;
}

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int number = new Random().Next(10, 10000);
Console.WriteLine(number);

if (number > 99)
    Console.Write(ConOutThreeNum(number));
else
    Console.Write("Число не имеет третьей цифры");