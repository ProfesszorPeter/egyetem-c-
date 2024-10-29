
namespace balaton
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Adott 10 napra a Balaton jegének vastagsága, válaszoljuk meg a következőket
             *
             * 1) Volt e olyan nap amikor lehetett korizni (>10)
             * 2) Hány nap lehetett korizni
             * 3) Mikor és milyen vastag volt, amikor a legvastagabb volt?
             * 4) Milyen hosszú volt a leghoszabb időszak amikor egyfolytában lehetett korizni?
             */

            int[] jan = new int[31];
            //feltöltés
            Random velGenarátor = new Random();
            //Console.WriteLine(velGenarátor.Next()%6+1);
            //Console.WriteLine(velGenarátor.Next(6));//0..5
            //Console.WriteLine(velGenarátor.Next(1,7));//1..6
            for (int i = 0; i<jan.Length;i++)
            {
                jan[i] = velGenarátor.Next(30);
            }
            //eldöntés tétele: lehet- e korizni
            for (int i = 0; i< jan.Length; i++)
            {
                if (jan[i] > 10)
                {
                    Console.WriteLine("Korizhatok!!");
                    break;
                }

            //szebben
            bool van = false;
            for(int i = 0; i < jan.Length && van == false; i++)
            {
                if (jan[i] > 10)
                {
                    Console.WriteLine("Korizhatok!!");
                }
            }

            }

            //Hány nap lehet korizni-megszámlálás tétele
            int db = 0;
            for(int i = 0; i< jan.Length; i++)
            {
                if(jan[i] > 10)
                    db ++;
            }
            Console.WriteLine($"Januárban {db} nap lehetett korizni");

            //Mikor és milyen vastag volt, amikor a legvastagabb volt?

            int maxIndex = 0;
            int maxErtek = jan[0];

            for(int i = 1; i<jan.Length; i++)
            {
                if (jan[i] > maxErtek)
                {
                    maxIndex = i;
                    maxErtek = jan[i];
                }
            }
            Console.WriteLine($"A legvastagabb jég {maxIndex +1}. volt");

            //ha több maximum érték is van
            //1.érték meghatározása



           // Milyen hosszú volt a leghoszabb időszak amikor egyfolytában lehetett korizni?
            int aktHossz = 0;
            int maxHossz = 0;
           for(int i = 0; i < jan.Length; i++)
           {
               if(jan[i]>10)
               {
                   aktHossz ++;
               }
               else
               {
                   aktHossz = 0;
               }
               if (aktHossz > maxHossz)
               {
                   maxHossz = aktHossz;

           }
               Console.WriteLine($"A leghoszabb időszak {aktHossz} nap volt");
           }
        }
    }
}
