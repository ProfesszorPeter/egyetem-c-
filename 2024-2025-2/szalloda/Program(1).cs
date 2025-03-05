using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace _1_het_ismetles
{
    internal class Program
    {
        struct adatsor
        {
            public int foglalas;
            public int szoba;
            public int erkezes;
            public int tavozas;
            public int vendeg;
            public int reggeli;
            public string nev;
            //művelet
            public int tartozkodasHossza()
            {
                return tavozas - erkezes;
            }
            public int ar()
            {
                int osszeg = 10000;
                if (erkezes < 121)
                    osszeg = 9000;
                if (erkezes >= 244)
                    osszeg = 8000;
                if (vendeg==3)  //pótágy
                    osszeg=+2000;
                if (reggeli == 1)   //reggeli
                    osszeg +=1100 * vendeg;
                return osszeg*tartozkodasHossza();
            }
            public string ToJson()
            {
                return JsonConvert.SerializeObject(this,Formatting.Indented);
            }
        }
        static List<adatsor>adatok=new List<adatsor>();

        static void Main(string[] args)
        {
            
            feladat1();
            feladat2();
            feladat3();
            JsonKi();
            JsonBE();
            Console.ReadKey();
        }

        private static void JsonBE()
        {
            kiir(5);
            List<adatsor>adatok2=new List<adatsor>();
            StreamReader be = new StreamReader("het2.json");
            string json = be.ReadToEnd();
            adatok2=JsonConvert.DeserializeObject<List<adatsor>>(json);
            be.Close();
        }

        private static void JsonKi()
        {
            kiir(4);
            StreamWriter ki=new StreamWriter("het.json");
            foreach (adatsor x in adatok)
            {
                if(x.tartozkodasHossza()>=7)
                ki.WriteLine(x.ToJson());
            }
            ki.Close();

            StreamWriter ki2 = new StreamWriter("het2.json");
            ki2.WriteLine(JsonConvert.SerializeObject(adatok,Formatting.Indented));
            ki2.Close();
        }

        private static void feladat3()
        {
            kiir(3);
            int osszBevetel = 0;
            StreamWriter ki = new StreamWriter("bevetel.txt");
            foreach (adatsor x in adatok)
            {
                ki.WriteLine($"{x.foglalas}:{x.ar()}");
                osszBevetel+=x.ar();
            }
            ki.Close();
            Console.WriteLine($"Éves bevátel {osszBevetel}Ft volt.");

        }

        private static void feladat2()
        {
            kiir(2);
            int maxHossz = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                adatsor x = adatok[i];
                if(maxHossz<x.tartozkodasHossza())
                {
                    maxHossz = x.tartozkodasHossza();
                }
            }
            for (int i = 0; i < adatok.Count; i++)
            {
                if (maxHossz == adatok[i].tartozkodasHossza())
                {
                    Console.WriteLine($"{adatok[i].nev} ({adatok[i].erkezes}) - {maxHossz}");
                }
            }
        }

        private static void feladat1()
        {
            StreamReader be = new StreamReader("pitypang.txt");
            int db = Convert.ToInt32(be.ReadLine());
            while(be.EndOfStream==false)
            {
                string sor=be.ReadLine();
                string[]reszek=sor.Split(' ');
                adatsor x=new adatsor(); //üres structúra
                x.foglalas = Convert.ToInt32(reszek[0]);
                x.szoba = Convert.ToInt32(reszek[1]);
                x.erkezes = Convert.ToInt32(reszek[2]);
                x.tavozas = Convert.ToInt32(reszek[3]);
                x.vendeg = Convert.ToInt32(reszek[4]);
                x.reggeli = Convert.ToInt32(reszek[5]);
                x.nev=reszek[6];
                adatok.Add(x);
            }
            be.Close();
        }

        private static void kiir(int v)
        {
            Console.WriteLine($"{v}. feladat");
        }
    }
}
