namespace felev2
{
    abstract class Gula
    {
        protected string tipus;
        protected int oldallapokSzama;
        protected static double pi = 3.1415;

        public void setTipus(string _tipus) {tipus = _tipus;}
        public string getTipus () {return tipus;}

        public void setOldallapokSzama(int _oldallapokSzama) {oldallapokSzama = _oldallapokSzama;}
        public int getOldallapokSzama() {return oldallapokSzama;}

        public Gula(string _tipus, int _oldallapokSzama)
        {
            tipus = _tipus;
            oldallapokSzama = _oldallapokSzama;
        }
        public Gula (int _oldallapokSzama)
        {
            tipus = "Gula";
            oldallapokSzama = _oldallapokSzama;
        }
        abstract public double felszin();
        abstract public double terfogat();
        
        public override string ToString()
        {
            return "----------------------------\n"
                + 
                $"Típus: {this.tipus}, oldallapokSzama: {this.oldallapokSzama}";
        }
    }
}
