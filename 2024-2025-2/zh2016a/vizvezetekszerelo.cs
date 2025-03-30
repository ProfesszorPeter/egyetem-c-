namespace felev2
{
    class Vizvezetekszerelo : Mesterember,Munka
    {
        private int tapasztalat;
        public int Tapasztalat
        {
            get { return tapasztalat; }
            set
            {
                if (value > tapasztalat)
                    tapasztalat = value;
            }

        }
        public Vizvezetekszerelo(string _nev, int _napidij, int _tapasztalat) : base(_nev, _napidij)
        {
            tapasztalat = _tapasztalat;
        }

        public override string ToString()
        {
            return base.ToString() + $"({tapasztalat} éve dolgozik)";
        }
        public override bool Munkatvalal(int s)
        {
            if (s-1 == 0|| s-1 == 30)
                return false;
            if (foglaltnapok[s-2] == false && foglaltnapok[s-1] == false && foglaltnapok [s] == false)
            {
                foglaltnapok[s-2] = true;
                foglaltnapok[s-1] = true ;
                foglaltnapok [s] = true;
                return true;
            }
            else
            {
                throw new Exception("Nincs elegendő nap");
            }
        }
        public int Kereset()
        {
            int nap = 0;
            for (int i = 0; i<foglaltnapok.Length; i++)
            {
                if (foglaltnapok[i] == true)
                    nap++;
            }
            return napidij * nap + 7*Mesterember.kiszallasiDij;
        }
    }
}

