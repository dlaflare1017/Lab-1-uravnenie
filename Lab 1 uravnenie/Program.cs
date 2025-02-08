using System;

class Program
{
    static void Main()
    {
        double x = 1.0; // Задайте значение x
        double y = 2.0; // Задайте значение y

        double result = Math.Pow(2, -x) - Math.Cos(x) + Math.Sin(2 * x * y);

        Console.WriteLine($"Результат: {result}");
    }
}
