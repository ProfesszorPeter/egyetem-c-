using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kocsma2024
{
    class Program
    {
        static void Main(string[] args)
        {
            int sörÁra = 500;
            int pénz = 2100;
            // számlálásos ciklus. ismert az ismétlések száma
            for(int i = 0; i < 4; i = i + 1)//i++
            {
                Console.WriteLine("Hmmmm, ez jól esett...");
                pénz = pénz - sörÁra;
            }
            Console.WriteLine("A sörözés után {0} Ft maradt", pénz);
            Console.WriteLine($"A sörözés után {pénz} Ft maradt");
            // Console.WriteLine("A sörözés után",pénz," Ft maradt");
            Console.WriteLine("A sörözés után" + pénz +" Ft maradt");
            pénz = 300;
            //tesztelő ciklusok
            Console.WriteLine("2. kocsma");
            //hátulteszteló
            do
            {
                //ciklusmag
                Console.WriteLine("Hmmmm, ez jól esett...");
                pénz = pénz - sörÁra;
            }
            while  (pénz >= sörÁra); //

            Console.WriteLine("A 2. sörözés után " + pénz + " Ft maradt");
            Console.WriteLine("3. kocsma");
            //előltesztelés
            pénz = 2400;
            while (pénz >= sörÁra)
            {
                //ciklusmag
                Console.WriteLine("Hmmmm, ez jól esett...");
                pénz = pénz - sörÁra;
            }
            Console.WriteLine("A 2. sörözés után " + pénz + " Ft maradt");
            Console.ReadKey();
        }
    }
}
