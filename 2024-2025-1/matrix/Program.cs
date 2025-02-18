namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] jatek =
            {
                {3,2,3,4,5,2,6},
                {4,3,5,2,4,5,6},
                {4,3,2,1,2,4,6}
            };
            string[] baratok = {"Jani", "Géza", "Anna"};

            for(int sor = 0; sor < 3; sor++)
            {
                Console.Write($"{baratok[sor]}: ");
                for(int oszlop = 0; oszlop < 7; oszlop++)
                {
                    Console.Write($"{jatek[sor,oszlop]}");
                }
                Console.WriteLine();

            }

            //1 típus, minden adatot használok
            //Hány órát játszottak a barátok napi átlagban
            int osszOra = 0;
            for (int sor = 0; sor < jatek.GetLength(0); sor ++)
            {
                for(int oszlop = 0; oszlop < jatek.GetLength(1); oszlop ++)
                {
                    osszOra = osszOra + jatek[sor,oszlop];
                }
                Console.WriteLine($"A baratok összesen {1.0*osszOra/jatek.Length:f2} órát játszottak naponta");

            }

            // 2. típus
            // Irassuk ki, hogy az egyes baratok mennyit játszottak külön - külön
            osszOra = 0;
            for (int sor = 0; sor < jatek.GetLength(0); sor ++)
            {
                for(int oszlop = 0; oszlop < jatek.GetLength(1); oszlop ++)
                {
                    osszOra = osszOra + jatek[sor,oszlop];
                }
                Console.WriteLine($"{sor + 1}. barát {osszOra} órát játszott a héten");

            }
            //3. típus
            //Irassuk ki, hogy melyik nap játszottak legtöbbet a barátok

            int maxNap = 0;
            int maxErtek = 0;
            for (int oszlop = 0; oszlop < jatek.GetLength(0); oszlop ++)
            {
                int osszErtek = 0;

                for(int sor = 0; sor < jatek.GetLength(1); sor ++)
                {
                    osszErtek = osszErtek + jatek[sor,oszlop];
                }
                if(maxErtek > osszErtek)
                {
                    maxErtek = osszErtek;
                    maxNap = oszlop;
                }
                Console.WriteLine($"A legatöbbet({maxErtek}) {maxNap + 1}. napon játszottak");
            }

            //4.típus
            //Kérjük be egy barát nevét(sorszámát) majd irassuk ki, hogy volt-e olyan nap amikor nem játszott!

            Console.Write("Kérem a barát nevét: ");
            string barat = Console.ReadLine();
            //lineáris keresés
            int baratSorszama = -1;
            for(int i = 0; i<baratok.Length; i++)
            {
                if(baratok[i] == barat);
            }
            
            Console.ReadKey();
    }
}
}

