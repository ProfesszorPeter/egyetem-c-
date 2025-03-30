namespace felev2
{
    class Burkolo : Mesterember, Munka
    {
        private string szakterulet;
        public string Szakterulet
        {
            get { return szakterulet; }
            set
            {
                if (value == "Belső" || value == "Külső")
                    szakterulet = value;
                else
                    throw new Exception("Nem megfelelő szakterület");
            }
        }
        public Burkolo(string _nev, int _napidij, string _szakterület) : base(_nev, _napidij)
        {
            szakterulet = _szakterület;
        }

        public int OsszesSzabadnap()
        {
            int ossz = 0;
            foreach (var nap in foglaltnapok)
                if (nap == false) ossz++;
            return ossz;
        }

        public override bool Munkatvalal(int s)
        {
            if (foglaltnapok[s - 1] == true)
                return false;
            else
            {
                foglaltnapok[s - 1] = true;
                return true;
            }
        }
        public override string ToString()
        {
            return base.ToString() + $"({szakterulet} burkoló)";
        }

        public int Kereset()
        {
            int nap = 31- OsszesSzabadnap();
            return napidij * nap + 10;
        }
    }
}
