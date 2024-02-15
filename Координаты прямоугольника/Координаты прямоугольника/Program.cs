using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Координаты_прямоугольника
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
            double p = 2 * (Math.Abs(x2 - x1) + Math.Abs(y2 - y1));
            double s = (Math.Abs(x2 - x1) * Math.Abs(y2 - y1));
            Console.WriteLine(p);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
