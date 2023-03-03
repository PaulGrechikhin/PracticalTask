// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();


int input(string massage)
{
    Console.Write(massage);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

int[] InputArray(int M)
{
    int[] arr = new int[M];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = input($"Введите {i + 1}-й элемент: ");
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.WriteLine($"a[{i}] = {arr[i]}");
}

int CountPos(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int M = input("Введите колличество элементов: ");
int[] array;
array = InputArray(M);
PrintArray(array);
Console.WriteLine($"Колличество чисел больше 0: {CountPos(array)}");