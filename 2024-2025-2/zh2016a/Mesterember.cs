namespace felev2
{
    abstract class Mesterember
    {
        public static int kiszallasiDij = 10000;
        protected string nev;
        protected int napidij;
        protected bool[] foglaltnapok = new bool[31];

        public Mesterember(string _nev, int _napidij)
        {
            nev = _nev;
            napidij = _napidij;
            for (int i = 0; i < foglaltnapok.Length; i++)
            {
                foglaltnapok[i] = false;
            }
        }
        public override string ToString()
        {
            string foglalt = "";
            for (int i = 0; i< foglaltnapok.Length; i++) {
                //if (foglaltnapok [0] == true) 
                //{
                //    foglalt += "X";
                //}
                //else 
                //{
                //    foglalt += "O";
                //}
                foglalt = foglaltnapok[i] == true ? foglalt + "X":foglalt + "O";
            }

            return string.Format("{0}({1}Ft): {2}",nev,napidij,foglalt);
        }
        public abstract bool Munkatvalal(int s);
    }
}
