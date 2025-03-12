namespace felev2
{
    class Tetraeder : Gula
    {
        protected double a;
        protected string mertekegyseg;

        public void setA(double a) { this.a = a; }
        public double getA() { return a; }

        public void setmertekegyseg(string mertekegyseg) { this.mertekegyseg = mertekegyseg; }
        public string getmertekegyseg() { return mertekegyseg; }

        public Tetraeder(double _a, string _mertekegyseg) : base("tetraéder", 3)
        {
            a = _a;
            mertekegyseg = _mertekegyseg;
        }

        public Tetraeder() : base("tetraéder", 3)
        {
            a = 10;
            mertekegyseg = "m";
        }

        public override double felszin()
        {
            return a * a * Math.Sqrt(3);
        }

        public override double terfogat()
                {
                    return a*a*a*Math.Sqrt(2)/12;
                }

        public override string ToString()
                {
                    return base.ToString() + $"\na = {a} {mertekegyseg}";
                }
    }
}
