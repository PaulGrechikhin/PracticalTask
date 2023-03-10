// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

Console.Clear();

const int b = 0;
const int k = 1;
const int X = 0;
const int Y = 1;
const int LINE_1 = 1;
const int LINE_2 = 2;

double[] lineData1 = InputData(LINE_1);
double[] lineData2 = InputData(LINE_2);

if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.Write($"Точка пересения линий y = {lineData1[b]}*x+{lineData1[k]} и y = {lineData2[b]} *x +{lineData2[k]}");
    Console.Write($" имеет координаты({coord[X]}, {coord[Y]})");
}

bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[b] == lineData2[b])
    {
        if (lineData1[k] == lineData2[k])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
        }
    }
    return true;
}

double input(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine()!;
    double result = Convert.ToDouble(value);
    return result;
}

double[] InputData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[b] = input($"Введите коэффициент для {numberOfLine} прямой: ");
    lineData[k] = input($"Введите константу для {numberOfLine} прямой: ");
    return lineData;
}

double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[X] = (lineData1[b] - lineData2[b]) / (lineData2[k] - lineData1[k]);
    coord[Y] = lineData1[b] * coord[X] + lineData1[k];
    return coord;
}