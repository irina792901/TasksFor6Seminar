/*Задача 43: Напишите программу, которая найдёт точку пересечения 
двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
D Тут несколько вариантов:
Вариант 1: вводим 4 числа просто так, без массива 


using static System.Console;
WriteLine("Прямая задана уравнением y=k*x+b");
FindPointOfIntersectionOfStraightLines(Input("k1 первой"),
Input("b1 первой"), Input("k2 второй"), Input("b2 второй"));


double Input(string Temp)
{
    Write($"Введите значение коэффициента {Temp} прямой: ");
    return double.Parse(ReadLine()!);
}


void FindPointOfIntersectionOfStraightLines(double k1, double b1, double k2, double b2)
{
    if (k1 == k2) WriteLine("Прямые параллельны");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1*x+b1;
        WriteLine($"({x}; {y})");
    }
}

Вариант 2: с использованием массива
*/

using static System.Console;
WriteLine("Прямая задана уравнением y=k*x+b");
double[] array = {Input("k1 первой"),Input("b1 первой"),
Input("k2 второй"), Input("b2 второй")};
WriteLine(FindPointOfIntersectionOfStraightLines(array));


double Input(string Temp)
{
    Write($"Введите значение коэффициента {Temp} прямой: ");
    return double.Parse(ReadLine()!);
}


string FindPointOfIntersectionOfStraightLines(double[] arr)
{
    string result;
    if (arr[0] == arr[2]) result = "Прямые параллельны";
    else
    {
        double x = (arr[3] - arr[1]) / (arr[0] - arr[2]);
        double y = arr[0] * x + arr[1];
        result = $"({x}; {y})";
    }
    return result;
}

