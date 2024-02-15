using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Lenght:");
            double L = Convert.ToDouble(Console.ReadLine());
            L = Math.Abs(L);
            double R = L / 2 / Math.PI;
            double Area = Math.PI * R * R;
            Console.WriteLine("Radius = {0} Area = {1}", R, Area);
            Console.WriteLine("Press any key to close");
            Console.ReadLine();
        }
    }
}
