namespace felev2
{
    class Kup:Gula
    {
        protected double r;
        protected double h;
        protected string mertekegyseg;

        public void setR(double r) {this.r = r;}
        public double getR() {return r;}

        public void setH(double h) {this.h = h;}
        public double getH() {return h;}

        public void setmertekegyseg(string mertekegyseg) {this.mertekegyseg = mertekegyseg;}
        public string getmertekegyseg() {return mertekegyseg;}

        public Kup(double r, double h, string mertekegyseg):base("Kúp",0)
        {
            this.r = r;
            this.h = h;
            this.mertekegyseg = mertekegyseg;
        }
        public Kup(): base("kúp",0)
        {
            r = 1;
            h = 2;
            mertekegyseg = "cm";
        }
        public double getAlkoto() {return Math.Sqrt(r*r + h*h);}

        public override double terfogat()
        {
            return r*r*h*pi / 3;
        }

        public override double felszin()
        {
            double a = getAlkoto();
            return r*r*pi+pi*r*a;
        }
    }
}
