using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tombok2024
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = { 22, 3, 45, 23, 2, 12, 87 };
            Console.WriteLine(t[3]);
            t[3] = 2 * t[3];
            Console.WriteLine(t[3]);
            Console.WriteLine(t.Length);
            //teljes bejárás
            int aktualisIndex = 0;
            for (int i = 100; i < 107; i++)
            {
                Console.Write($" {t[aktualisIndex]}");
                aktualisIndex += 1;
            }
            //a tomb elérésehez hazsnálhatjuk az ciklusváltozót is!
            Console.WriteLine();
            for (int i = 0; i < 7; i++)
            {
                Console.Write($" {t[i]}");                
            }

            Console.WriteLine();
            int osszeg = 0;
            for (int i = 0; i < t.Length; i++)
            {
                osszeg += t[i];
                // osszeg = osszeg + t[i];
            }
            Console.WriteLine($"Összege: {osszeg}");
            Console.ReadKey();
        }
    }
}
