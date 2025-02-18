using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evszak2024
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Feladat: kérjük be egy hónap sorszámát és irassuk ki, hogy
             melyik évszakba esik!
             */
            int ho;
            Console.Write("Kérem a hónap sorszámát: ");
            string be = Console.ReadLine();
            ho = Convert.ToInt32(be);

            // nagyon egyszerű megoldás (python)
            if (ho == 1) Console.WriteLine("Tél");
            if (ho == 2) Console.WriteLine("Tél");
            if (ho == 3) Console.WriteLine("Tavasz");
            if (ho == 4) Console.WriteLine("Tavasz");
            if (ho == 5) Console.WriteLine("Tavasz");
            if (ho == 6) Console.WriteLine("Nyár");
            if (ho == 7) Console.WriteLine("Nyár");
            if (ho == 8) Console.WriteLine("Nyár");
            if (ho == 9) Console.WriteLine("Ősz");
            if (ho == 10) Console.WriteLine("Ősz");
            if (ho == 11) Console.WriteLine("Ősz");
            if (ho == 12) Console.WriteLine("Tél");
            //kicsit jobb
            if (ho == 1 || ho == 2 || ho == 12) Console.WriteLine("Tél");
            if (ho == 3 || ho == 4 || ho == 5) Console.WriteLine("Tavasz");
            if (ho == 6 || ho == 7 || ho == 8) Console.WriteLine("Nyár");
            if (ho == 9 || ho == 10 || ho == 11) Console.WriteLine("Ősz");
            //szépen :)
            switch (ho)
            {
                case 1: Console.WriteLine("Tél");break;
                case 2: Console.WriteLine("Tél");break;
                case 12: Console.WriteLine("Tél");break;
                case 3: 
                case 4: 
                case 5: Console.WriteLine("Tavasz"); break;
                case 6: Console.WriteLine("Nyár"); break;
                case 7: Console.WriteLine("Nyár"); break;
                case 8: Console.WriteLine("Nyár"); break;
                case 9: Console.WriteLine("Ősz"); break;
                case 10: Console.WriteLine("Ősz"); break;
                case 11: Console.WriteLine("Ősz"); break;
                default: Console.WriteLine("Ilyen hónap nincs!");break;
            }

            Console.ReadKey();
        }
    }
}
