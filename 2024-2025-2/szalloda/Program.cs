//json meg a többi befejezés
using Newtonsoft.Json;
namespace felev2
{
    class Szalloda
    {
        struct Adatsor
        {
            public int fogl;
            public int szoba;
            public int erk;
            public int tav;
            public int vendeg;
            public int reggeli;
            public string nev;

            //művelet
            public int TartozkodasHossza()
            {
                return tav - erk;
            }
            public int Ar()
            {
                int osszeg = 1000;//alapár
                if (erk < 121)
                {
                    osszeg = 9000;
                }
                if (erk >= 224)
                {
                    osszeg = 8000;
                }

                if (vendeg == 3)
                {
                    osszeg += 2000;
                }

                if (reggeli == 1)
                {
                    osszeg += 1100 * vendeg;
                }
                return osszeg * TartozkodasHossza();
            }
            public string ToJason()
            {
                return JsonConvert.SerializeObject(this);
            }
        }

        static List<Adatsor> adatok = new List<Adatsor>();

        static void Main(string[] args)
        {
            feladat1();
            feladat2();
            feladat3();
        }
        private static void feladat3()
        {
            kiir(3);
            int osszbevetel = 0;
            StreamWriter ki = new StreamWriter("bevetel.txt");
            foreach (Adatsor x in adatok)
            {
                ki.WriteLine($"{x.fogl}:{x.Ar()}");
                osszbevetel += x.Ar();

            }
            ki.Close();
            Console.WriteLine($"Éves bevetel {osszbevetel} Ft volt.");

        }


        private static void feladat2()
        {
            kiir(2);
            //valami nem stimmel
            int maxhossz = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                Adatsor x = adatok[i];
                if (maxhossz > x.TartozkodasHossza())
                {
                    maxhossz = x.TartozkodasHossza();
                }
            }
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].TartozkodasHossza() == maxhossz)
                {
                    Console.WriteLine($"{adatok[i].nev} ({adatok[i].erk}) - {maxhossz}");
                }
            }
        }

        private static void feladat1()
        {
            StreamReader be = new StreamReader("pitypang.txt");
            int db = Convert.ToInt16(be.ReadLine());

            while (be.EndOfStream == false)
            {
                string sor = be.ReadLine();
                string[] reszek = sor.Split(' ');

                Adatsor x = new Adatsor(); //üres struktúra
                x.fogl = Convert.ToInt16(reszek[0]);
                x.szoba = Convert.ToInt16(reszek[1]);
                x.erk = Convert.ToInt16(reszek[2]);
                x.tav = Convert.ToInt16(reszek[3]);
                x.vendeg = Convert.ToInt16(reszek[4]);
                x.reggeli = Convert.ToInt16(reszek[5]);
                x.nev = reszek[6];
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

