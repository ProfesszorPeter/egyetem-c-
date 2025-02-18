using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elso20024
{
    class Program
    {
        /*
         Többsoros komment: mai tananyag a programozás építőköveinek megismerése.
         Nem lesz sok. :)
             */
        static void Main(string[] args)
        {
            //adat kivitel  -egysoros megjegyzés
            Console.Write("Macska");
            Console.WriteLine("Szeretek programozni!");

            Console.Write("Kérek egy szép számot: ");
            string beAdat;
            beAdat = Console.ReadLine();

            Console.Write("A beadott adat:");
            Console.WriteLine(beAdat);
            // bujtatva a második elem: értékadás
            // változó = kifejezés;
            int x;
            x = 50;
            Console.WriteLine(x* Convert.ToInt32(beAdat));
            double y;
            y = 5 * x / 100.0;
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
