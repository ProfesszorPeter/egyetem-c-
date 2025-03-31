namespace felev2
{
    class Program
    {
        public static void Main(string[] args)
        {
            StreamReader forras = new StreamReader("allomany.txt");
            string forrastartalom = forras.ReadToEnd();
            string[] forrastartalomsorok = forrastartalom.Split("\n");

            Tehetseg[] tehetsegek = new Tehetseg[forrastartalomsorok.Length/2];

            for (int i = 0; i<forrastartalomsorok.Length-2;i = i+2)
            {
                string sor1 = forrastartalomsorok[i];
                string sor2 = forrastartalomsorok[i+1];

                string[] sor1elemek = sor1.Split(";");
                string[] sor2elemek = sor2.Split(";");
                
                //Tehetseg versenyzo2 = new Tehetseg();
                //versenyzo2.Nev = sor1elemek[0];
                //versenyzo2.KozossegPont = Convert.ToInt16(sor1elemek[1]);
                Tehetseg versenyzo = new Tehetseg{
                    Nev = sor1elemek[0],
                    KozossegPont = Convert.ToInt16(sor1elemek[1]),

                    Zsuri1Pont = Convert.ToInt16(sor2elemek[0]),
                    Zsuri2Pont = Convert.ToInt16(sor2elemek[1]),
                    Zsuri3Pont = Convert.ToInt16(sor2elemek[2]),
                    Zsuri4Pont = Convert.ToInt16(sor2elemek[3]),
                };
                tehetsegek[i/2] = versenyzo;
            }
            Kiir(tehetsegek);

            string versenyzoNev = "Szép Elek";
            Console.WriteLine("{0} versenyző zsűripontjai: {1}", versenyzoNev, ZsuriPont(versenyzoNev, tehetsegek));

            minZsuri(3, tehetsegek);
        }

        private static void minZsuri(int zsuriIndex, Tehetseg[] tehetsegek) {
            int minZsuripont = 10000;
            string mintehetsegnev = "";

            foreach (Tehetseg tehetseg in tehetsegek)
            {
                if (zsuriIndex == 1){

                    if(tehetseg.Zsuri1Pont < minZsuripont)
                    {
                        minZsuripont = tehetseg.Zsuri1Pont;
                        mintehetsegnev = tehetseg.Nev;
                    }
                }
                if (zsuriIndex == 2) {
                    if(tehetseg.Zsuri2Pont < minZsuripont)
                    {
                        minZsuripont = tehetseg.Zsuri2Pont;
                        mintehetsegnev = tehetseg.Nev;
                    }

                }
                if (zsuriIndex == 3) {
                    if(tehetseg.Zsuri3Pont < minZsuripont)
                    {
                        minZsuripont = tehetseg.Zsuri3Pont;
                        mintehetsegnev = tehetseg.Nev;
                    }

                }
                if (zsuriIndex == 4) {
                    if(tehetseg.Zsuri4Pont < minZsuripont)
                    {
                        minZsuripont = tehetseg.Zsuri4Pont;
                        mintehetsegnev = tehetseg.Nev;
                    }

                }
            }
            Console.WriteLine("A legkevesebb pontot {0} kapta a(z) {1}. zsűri tagtól", mintehetsegnev, zsuriIndex);
        }

        private static int ZsuriPont (string nev, Tehetseg[] tehetsegek) {
            int zsuripont = 0;
            foreach (var tehetseg in tehetsegek) {
                if (tehetseg.Nev == nev) {
                    zsuripont = tehetseg.Zsuri1Pont+tehetseg.Zsuri2Pont+tehetseg.Zsuri3Pont+tehetseg.Zsuri4Pont;
                }
            }
            return zsuripont;

        }

        private static void Kiir(Tehetseg[] tehetsegek) {
            foreach (var tehetseg in tehetsegek)
            {
                Console.WriteLine("{0}\t {1} {2} {3} {4} {5}", tehetseg.Nev, tehetseg.KozossegPont, tehetseg.Zsuri1Pont, tehetseg.Zsuri2Pont, tehetseg.Zsuri3Pont, tehetseg.Zsuri4Pont);
            }
        }
    }
    class Tehetseg
    {
        public string Nev;
        public int KozossegPont;
        public int Zsuri1Pont;
        public int Zsuri2Pont;
        public int Zsuri3Pont;
        public int Zsuri4Pont;

    }
}

