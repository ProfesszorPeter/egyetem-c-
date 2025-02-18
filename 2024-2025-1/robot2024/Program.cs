﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robot2024
{
    class Program
    {
        static string[] adatok = new string[100];
        static int db = 0;
        static void Main(string[] args)
        {
            //beolvasás
            StreamReader be = new StreamReader("program.txt");
            db = Convert.ToInt32(be.ReadLine());
            for (int i = 0; i < db; i++)
            {
                adatok[i] = be.ReadLine();
            }
            be.Close();
            Console.Write("Kérem egy utasítás sorszámát:");
            int sorszam = Convert.ToInt32(Console.ReadLine());
            feladat2a(sorszam);
            feladat2b(sorszam);
            feladat2c();
            Console.ReadKey();
        }

 

        private static void feladat2a(int ssz)
        {
            string program = adatok[ssz-1];
            //régi módon
            bool e = false;
            for (int i = 0; i < program.Length-1; i++)
            {
                if (program[i] == 'E' && program[i + 1] == 'D')
                    e = true;
                if (program[i] == 'D' && program[i + 1] == 'E')
                    e = true;
                if (program[i] == 'N' && program[i + 1] == 'K')
                    e = true;
                if (program[i] == 'K' && program[i + 1] == 'N')
                    e = true;
            }
            if(e==true)
                Console.WriteLine("Egyszerűsíthető");
            else
                Console.WriteLine("Nem egyszerűsíthető");
            //új módon: fgv-nyel
            if(program.Contains("ED")==true ||
                program.Contains("DE") == true ||
                program.Contains("NK") == true ||
                program.Contains("KN") == true)
                Console.WriteLine("Egyszerűsíthető");
            else
                Console.WriteLine("Nem egyszerűsíthető");
        }

        private static void feladat2b(int ssz)
        {
            string program = adatok[ssz];
            int dbED = 0;
            int dbNK = 0;
            for (int i = 0; i < program.Length; i++)
            {
                if (program[i] == 'E')
                    dbED++;
                if (program[i] == 'D')
                    dbED--;
                if (program[i] == 'N')
                    dbNK++;
                if (program[i] == 'K')
                    dbNK--;
            }
            Console.WriteLine($"{Math.Abs(dbED)} lépést kell tenni az ED, {Math.Abs(dbNK)} lépést a KN tengely mentén.");
        }

        private static void feladat2c()
        {

        }
    }
}
