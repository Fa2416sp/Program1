using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1, i2, i3;
            double d1, d2, d3, X, Y, Z;
            Console.WriteLine("Ishodnie dannie");
            Console.WriteLine("Vvedite tzelie i1, i2, i3 i deistvitelnoe d1, d2, d3:");
            Console.Write("i1 = ");
            i1 = Int32.Parse(Console.ReadLine());
            Console.Write("i2 = ");
            i2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("i3 = ");
            i3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("d1 = ");
            d1 = double.Parse(Console.ReadLine());
            Console.Write("d2 = ");
            d2 = double.Parse(Console.ReadLine());
            Console.Write("d3 = ");
            d3 = double.Parse(Console.ReadLine());
            X = ((double)103 / 3) * ((double)i1 / (i2 + 13)) * (d1 + d2 + d3);
            Y = ((double)d1 / (d2 * d3)) + ((double)i3 / (i1 + 12));
            Z = d1 * ((double)(i1 + i2) / d2) + ((double)i3 / (i1 * i2));
            Console.WriteLine("Rezultati:");
            Console.WriteLine("X = {0:##.###}", X);
            Console.WriteLine("Y = {0:##.###}", Y);
            Console.WriteLine("Z = {0:##.####}", Z);
            Console.ReadKey();
        }
    }
}