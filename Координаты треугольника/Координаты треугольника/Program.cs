using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Координаты_треугольника
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Координаты x1, y1:");
            Console.Write("x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Координаты x2, y2:");
            Console.Write("x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Координаты x3, y3:");
            Console.Write("x3: ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y3: ");
            double y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double a1 = x2 - x1;
            double b1 = y2 - y1;
            double a = Math.Sqrt(a1 * a1 + b1 * b1);
            double a2 = x3 - x2;
            double b2 = y3 - y2;
            double b = Math.Sqrt(a2 * a2 + b2 * b2);
            double a3 = x3 - x1;
            double b3 = y3 - y1;
            double c = Math.Sqrt(a3 * a3 + b3 * b3);
            //  Console.WriteLine("{0},{1},{2}", a,b,c);
            double p = a + b + c;
            double p1 = p / 2;
            double s = Math.Sqrt(p1 * (p1 - a) * (p1 - b) * (p1- c));
            Console.WriteLine("{0},{1},{2}, p={3}, s={4}", a, b, c,p,s);
            Console.ReadKey();
        }
    }
}
