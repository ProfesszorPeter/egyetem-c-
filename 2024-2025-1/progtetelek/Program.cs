namespace progtetelek
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] t = {2,4, -3, 5, 22, 4, 13, 43, 21, 7};
            //buborék
            for(int j = 0; j < t.Length-1-j; j++)
            {
                for(int i = 0; i<t.Length-1;i++)
                {
                    if (t[i] > t[i+1])
                    {
                        //csere
                        csere(ref t[i], ref t[i+1]);
                       /* 
                        int temp = t[i];
                        t[i] = t[i+1];
                        t[i+1] = temp;
                       */ 
                    }
                }
            }
            //kiiratás
            for(int i = 0; i < t.Length; i++)
            {
                Console.Write($"{t[i]} ");
            }
            static void csere(ref int a, ref int b)
            {
                        int temp = a;
                        a = b;
                        b = temp;

            }

            //minumum kiválasztás tétele
            int[] t1 = {2,3,23,-4,7,12,-100,3};
            
            int minIndex = 0;
            for(int i = 1;i<t1.Length;i++)
            {
                if(t1[i] < t1[minIndex])
                    minIndex = i;
            }
            Console.WriteLine($"\nMinimum értéke: {t1[minIndex]}, sorszáma: {minIndex+1}");

            //maximum kiválasztás tétele

            int maxIndex = 0;
            int maxErterk = t1[0];
            for(int i = 1; i< t1.Length; i++)
            {
                if(t1[i] > maxErterk)
                {
                    maxErterk = t1[i];
                    maxIndex = i;
                }
            }
            Console.WriteLine($"\nMaximum értéke: {maxErterk}, sorszáma: {maxIndex}");


            //Összegszés tétele
            //sorozat most billentyűzetről jön!
            //feladat: Kérjük be Pista költségeit napra bontva és határozzuk meg  az általános napi költséglének értékét
            int osszeg = 0;
            for (int i = 0; i < 7; i++)
            {
                Console.Write("")
            }
        }
    }
}

