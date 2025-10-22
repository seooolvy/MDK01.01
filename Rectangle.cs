using System;

class RectangleProgram
{
    static void Main()
    {
        Console.Write("Введите длину прямоугольника: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите ширину прямоугольника: ");
        double b = double.Parse(Console.ReadLine());

        double P = 2 * (a + b);
        double S = a * b;

        Console.WriteLine($"Периметр: {P}");
        Console.WriteLine($"Площадь: {S}");
    }
}
