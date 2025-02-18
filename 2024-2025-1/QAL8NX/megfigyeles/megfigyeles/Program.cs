using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace megfigyeles
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
        
            string[] tomb = beolvas();
            
            dbOra(tomb);

            Console.WriteLine("Adja meg mit szeretne megfiygelni(sorozat/tűzijáték/petárda): ");
            string fajta = Console.ReadLine();
            dbFajta(fajta, tomb);

            statisztika(tomb);

            Console.ReadKey();
        }

        private static void statisztika(string[] tomb)
        {
            StreamWriter statisztika = new StreamWriter("statisztika.txt");
            int ora = 8;
            int db = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (!tomb[i].Contains("--"))
                {
                    db++;
                   
                }
                else
                {
                    db = 0;
                    ora++;
                }
                statisztika.WriteLine($"{ora} óra: {db} db");
            }
            statisztika.Close();
        }

        private static void dbFajta(string fajta, string[] tomb)
        {
            int fajtadb = 0;
            for(int i = 0;i<tomb.Length;i++)
            {
                if(tomb[i] == fajta)
                {
                    fajtadb++;
                }
            }
            Console.WriteLine($"{fajtadb} db {fajta} volt megfigyelhető a leskelődés alatt.");
        }

        private static void dbOra(string[] tomb)
        {
            int dbora = 1;
            for(int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i].Contains("--"))
                {
                    dbora ++;
                }
            }
            Console.WriteLine("{0} át figyelte az eseményeket.", dbora);

        }

        private static string[] beolvas()
        {
            string[] megfigyelesek = new string[18];
            int index = 0;
            StreamReader adatok = new StreamReader("megfigyeles.txt");
            string sor = adatok.ReadLine();
            while (sor != null)
            {
                megfigyelesek[index] = sor;
                index++;
                sor = adatok.ReadLine();
            }
            adatok.Close();
            return megfigyelesek;
        }
    }
}
