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

            Console.WriteLine($"Окружность: {C}");
        }
    }
}
