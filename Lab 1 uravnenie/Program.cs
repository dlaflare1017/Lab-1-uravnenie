using System;

class Program
{
    static void Main()
    {
        double x = 1.0;
        double y = 2.0; 

        double result = Math.Pow(2, -x) - Math.Cos(x) + Math.Sin(2 * x * y);

        Console.WriteLine($"Результат: {result}");
    }
}
