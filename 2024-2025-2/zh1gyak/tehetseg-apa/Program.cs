namespace felev2
{
    class Tehetseg
    {
        private string Nev;
        private int Kozonseg;
        private int zsuritag1;
        private int zsuritag2;
        private int zsuritag3;
        private int zsuritag4;

        private void setNev(string _Nev) { Nev = _Nev; }
        public string setNev() { return Nev; }

        public void setKozonseg(int Kozonseg) { this.Kozonseg = Kozonseg; }
        public int getKozonseg() { return Kozonseg; }

        public void setZsuritag1(int zsuritag1) { this.zsuritag1 = zsuritag1; }
        public int getZsuritag1() { return zsuritag1; }

        public void setZsuritag2(int zsuritag2) { this.zsuritag2 = zsuritag2; }
        public int getZsuritag2() { return zsuritag2; }

        public void setZsuritag3(int zsuritag3) { this.zsuritag3 = zsuritag3; }
        public int getZsuritag3() { return zsuritag3; }

        public void setZsuritag4(int zsuritag4) { this.zsuritag4 = zsuritag4; }
        public int getZsuritag4() { return zsuritag4; }

        public Tehetseg(string _Nev)
        {
            setNev(_Nev);
        }

        static private void Main(string[] args)
        {
            StreamReader forras = new StreamReader("allomany.txt");
            string resz = forras.ReadToEnd();
            string[] adatok = resz.Split("\n");
            forras.Close();

            Tehetseg[] tehetsegek = new Tehetseg[adatok.Length];

            for (int i = 0; i < adatok.Length - 1; i++)
            {
                //Console.WriteLine(adatok[i]);

                if (i % 2 == 0)
                {
                    string[] lofasz = adatok[i].Split(";");
                    tehetsegek[i] = new Tehetseg(lofasz[0]);
                    tehetsegek[i].setKozonseg(Convert.ToInt16(lofasz[1]));
                }
                else
                {
                    string[] lofasz = adatok[i].Split(";");
                    tehetsegek[i-1].setZsuritag1(Convert.ToInt16(lofasz[0]));
                    tehetsegek[i-1].setZsuritag2(Convert.ToInt16(lofasz[1]));
                    tehetsegek[i-1].setZsuritag3(Convert.ToInt16(lofasz[2]));
                    tehetsegek[i-1].setZsuritag4(Convert.ToInt16(lofasz[3]));
                }
            }

            for (int i = 0; i<tehetsegek.Length; i++)
            {
                Console.WriteLine(tehetsegek[i]);
            }
        }
    }
}

