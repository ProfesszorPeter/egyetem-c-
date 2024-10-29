namespace gyakorlo
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,]jatek = {
                {3,2,3,4,5,2,6},
                {4,3,5,2,4,5,6},
                {4,3,2,1,2,4,6},
            };
            string [] baratok = {"Balázs", "Levi", "Gyuri"};

            //kiíratás
            for(int sor = 0; sor<jatek.GetLength(0); sor++)
            {
                Console.Write($"\n{baratok[sor]}: ");

                for(int oszlop = 0; oszlop<jatek.GetLength(1); oszlop ++)
                {
                    Console.Write(jatek[sor,oszlop]);
                }
            }

            Console.WriteLine("\n1. feladat");
            //Hány órát játszottak a barátok napi átlagban

            for(int i =0; i < jatek.GetLength(0); i ++)
            {
                int ossz = 0;
                for(int j = 0; j<jatek.GetLength(1); j ++)
                {
                    ossz = ossz + jatek[i,j];
                }
                Console.WriteLine($"{1.0*ossz/jatek.Length:f2} órát játszottak a baratok napi átlagban");
            }

            Console.WriteLine("\n2.feladat");
            // Irassuk ki, hogy az egyes baratok mennyit játszottak külön - külön

            for(int i = 0; i<jatek.GetLength(0); i++)
            {
                int jatszottOra = 0;

                for(int j = 0; j<jatek.GetLength(1); j++)
                {
                    jatszottOra = jatszottOra+jatek[i,j];
                }
                Console.WriteLine($"{baratok[i]}: {jatszottOra} órát játszott összesen");
            }

            Console.WriteLine("\n3.feladat");
            //Irassuk ki, hogy melyik nap játszottak legtöbbet a barátok

            for(int i = 0; i<jatek.GetLength(0); i++)
            {
                for(int j = 0; j<jatek.GetLength(1); j++)
                {

                }
            }

        }
    }
}
