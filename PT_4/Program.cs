Console.Clear();

//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

double[] Array = new double[3];
int index = 0;
int length = Array.Length;

/*Console.Write("Введите первое число: ");
double.TryParse(Console.ReadLine()!, out Array[0]);

Console.Write("Введите второе число: ");
double.TryParse(Console.ReadLine()!, out Array[1]);

Console.Write("Введите второе число: ");
double.TryParse(Console.ReadLine()!, out Array[2]);*/

while(index < length)
{
    int count = 1;
    Console.Write($"Введите {count}-ое число: ");
    double.TryParse(Console.ReadLine()!, out Array[index]);
    count++;
    index++;
}

index = 1;
double max = Array[0];

while(index < length)
{
    if (Array[index] > max)
    {
        max = Array[index];
    }

    index++;
}

Console.Write($"max = {max}");