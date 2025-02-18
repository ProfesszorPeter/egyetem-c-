using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baratnok
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[,] szamok =
          {
                {4,12,4},
                {11,19,5 },
                {8,11,2 },
                {6,9,9}
            };
            string[] nevek = { "Julcsi", "Ancsi", "Pamacs", "Csillu" };

            petarda(szamok);
            KIIR(2);

            Console.WriteLine("Adja meg az egyik lány nevét: ");
            string nev = Console.ReadLine();
            int index = 0;
            for(int i = 0; i < nevek.Length; i++)
            {
                if(nevek[i] == nev)
                {
                    index = i; break;
                }
            }
            lanyAdat(nev, szamok, index);

            kategoriaAtlag(szamok);

            int tobb;
            Sok(szamok, out tobb);
          
            Console.WriteLine($"{tobb} alkalommal volt 10-nél több megfigyelés.");
    
            Console.ReadKey(); 
        }

        private static void Sok(int[,] szamok, out int tobb)
        {
            KIIR(4);
             tobb = 0;
            for(int i = 0;i < szamok.GetLength(0); i++)
            {
                for(int j = 0;j < szamok.GetLength(1); j++)
                {
                    if (szamok[i,j] > 10)
                    {
                        tobb++;
                    }

                }
               
            }
        }

        private static void kategoriaAtlag(int[,] szamok)
        {
            KIIR(3);
            int petardaDB = 0;
            int tuzijatekDB = 0;
            int soktuzijatekDB = 0;
            for (int i = 0;i< szamok.GetLength(0); i++)
            {
                petardaDB += szamok[i,0];
                tuzijatekDB += szamok[i,1];
                soktuzijatekDB += szamok[i, 2];
            }
            //Console.WriteLine("Skill issue?");
            //Console.WriteLine(petardaDB);
            //Console.WriteLine(tuzijatekDB);
            //Console.WriteLine(soktuzijatekDB);
            Console.WriteLine($"Átlagosan {petardaDB/4.0} db petárdát, {tuzijatekDB/4.0} db egyes tüzijátékot és {soktuzijatekDB/4.0} db sorozattüzijátékot láttak");

        }

        private static void lanyAdat(string nev, int[,] szamok, int index)
        {
           
                Console.WriteLine("{0} {1} {2}",szamok[index,0], szamok[index,1], szamok[index,2]);
          
        }

        private static void petarda(int[,] szamok)
        {
            KIIR(1);
            int petardaDB = 0;
            for (int i = 0; i < szamok.GetLength(0); i++)
            {
                petardaDB = petardaDB + szamok[i, 0];
            }
            Console.WriteLine($"Öszesen {petardaDB} petárdát hallottak.");
        }

        private static void KIIR(int v)
        {
            Console.WriteLine($"\n{v}. feladat");
        }
    }
}
