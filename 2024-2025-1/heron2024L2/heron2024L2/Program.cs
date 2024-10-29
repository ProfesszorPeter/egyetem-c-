using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heron2024L2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Kérem a háromszög oldalait:");
            Console.Write("a=");
            a =Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c=");
            c = Convert.ToInt32(Console.ReadLine());
            double s = a + b + c / 2;
            double T;
            T = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine("T = " + T);
            Console.ReadKey();
        }
    }
}
