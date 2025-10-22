using System;

namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус: ");
            double R = double.Parse(Console.ReadLine());

            double C = 2 * Math.PI * R;
            double S = Math.PI * Math.Pow(R, 2);

            Console.WriteLine($"Окружность: {C}");
            Console.WriteLine($"Площадь: {S}");
        }
    }
}
