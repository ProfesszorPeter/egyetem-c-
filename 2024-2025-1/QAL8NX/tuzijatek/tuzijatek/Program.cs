using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuzijatek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int petardaar = 500;
            int tuzijatekar = 4000;
            int soktuzijatekar = 15000;
            Console.WriteLine("Adja meg hány petárdát vásárolt János: ");
            int petárdakDB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg hány tüzijátékot vásárolt János: ");
            int tuzijatkDB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg hány sorozat tüzijátékot vásárolt János: ");
            int soktuzijatkDB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Összesen: {petardaar * petárdakDB + tuzijatekar * tuzijatkDB + soktuzijatekar * soktuzijatkDB}");

            Console.ReadKey();
        }
    }
}
