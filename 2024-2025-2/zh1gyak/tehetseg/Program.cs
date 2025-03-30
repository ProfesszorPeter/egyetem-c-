namespace felev2
{
    class Tehetseg
    {
        struct Adatok
        {
            public string Nev;
            public int Kozonseg;
            public int zsuritag1;
            public int zsuritag2;
            public int zsuritag3;
            public int zsuritag4;
        }
        
        //public string Nev;
        //public int Kozonseg;
        //public int zsuritag1;
        //public int zsuritag2;
        //public int zsuritag3;
        //public int zsuritag4;

        //public Tehetseg{"Kis István",1,2,3,4,5 }

        static private void Main(string[] args)
        {
            StreamReader forras = new StreamReader("allomany.txt");
            string resz = forras.ReadToEnd();
            string[] reszadatok = resz.Split("\n");
            int[] pontok = new int[30];

            for (int i = 0; i<reszadatok.Length; i++)
            {
                Console.WriteLine("egy elem: {0}",reszadatok[i]);
                Console.WriteLine();
                //Adatok x;
                //x.Nev = item[
            }
        }
    }
    
}

