namespace felev2
{
    class Program
    {
        class Deltoid
        {
            double e, f;
            string tipus;
            string mertekegyseg;
            public double getE() { return e; }
            public double getF() { return f; }
            public string getTipus() { return tipus; }
            public string getMertekegyseg() { return mertekegyseg; }

            public void setE(double _e) { e = _e; }
            public void setF(double _f) { e = _f; }
            public void setTipus(string _tipus) { tipus = _tipus; }
            public void setMertekegyseg(string _mertekegyseg) { mertekegyseg = _mertekegyseg; }
        }

        public Deltoid(double e, double f, string tipus, string mertekegyseg)
        {
            this.e = e;
            this.f = f;
            this.tipus = tipus;
            this.mertekegyseg = mertekegyseg;
        }

        public Deltoid(double e)
        {
            this.e = e;
            this.f = e;
            this.tipus = "konkáv";
            this.mertekegyseg = "cm";
        }

        public double Terulet() { return e * f / 2; }
        public double Kerulet() { return 10; }

        public string ToString()
        {
            return String.Format($"e={e} {mertekegyseg}, f={f} {mertekegyseg}, {tipus}");
        }

        static void Main(string[] args)
            {
                Deltoid x = new Deltoid(3,4, "konvex", "cm");
                Deltoid x = new Deltoid(2);
            }
        }
    }
