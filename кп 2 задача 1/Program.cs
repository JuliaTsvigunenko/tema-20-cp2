using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            // целые
            Triangle<int> triInt = new Triangle<int>();
            Console.WriteLine($"Целочисленный треугольник: ");
            Console.WriteLine($"Площадь: {triInt.Area(5, 4, 3)}");

            // беззнаковые целые
            Triangle<uint> triUint = new Triangle<uint>();
            Console.WriteLine($"\nБеззнаковый целочисленный треугольник: ");
            Console.WriteLine($"Площадь: {triUint.Area(11, 21, 31)}");

            // вещественные
            Triangle<double> triDouble = new Triangle<double>();
            Console.WriteLine($"\nВещественный треугольник: ");
            Console.WriteLine($"Площадь: {triDouble.Area(1.2, 1.8, 3.0)}");

            Console.ReadKey();









        }
    }
}
