using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Triangle<T>
    {

        public T a { get; set; }

        public T b { get; set; }

        public T c { get; set; }
        

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Triangle()
        {
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public Triangle( T a, T b, T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// Метод вывода информации о сторонах треугольника
        /// </summary>
        public void ShowInfo()
        {
            Console.Write($"Сторона a = {a}\nСторона b ={b}\nСторона c = {c}");
        }


        public double Area(double a, double b, double c)
        {
            double perimetr = a + b + c;
            double polyperimetr = (perimetr / 2);
            return Math.Sqrt(polyperimetr * (polyperimetr - a) * (polyperimetr - b) * (polyperimetr - c));
        }









    }
}
