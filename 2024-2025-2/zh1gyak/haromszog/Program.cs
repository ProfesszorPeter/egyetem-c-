using Newtonsoft.Json;
namespace felev2
{
    class Haromszog
    {
        private float a;
        private float b;
        private float c;
        private string tipus;
        private string mertekegyseg;

        public float A{
            set{ a=value; }
            get{return a;}
        }

        public float B{
            set { b = value;}
            get { return b;}
        }

        public float C {
            set { c = value; }
            get { return c; }
        }

        public string Tipus{
            set {tipus = value;}
            get {return tipus;}
        }

        public string Mertekegyseg{
            set {mertekegyseg = value;}
            get {return mertekegyseg;}
        }

        public float Kerulet{
            get {
                return a+b+c;
            }
        }

        public double Terulet{
            get{
                float s = (a+b+c)/2;

                return Math.Sqrt(s*(s-a)*(s-b)*(s-c));
            }
        }


        public Haromszog(float a, float b, float c, string tipus, string mertekegyseg)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.tipus = tipus;
            this.mertekegyseg = mertekegyseg;
        }

        public Haromszog(float d):this(d,d,d,"szabályos","cm")
        {
            // egyszerű... :)
           // a = d;
           // b = d;
           // c = d;
           // mertekegyseg = "cm";
           // tipus = "szabályos";
        }

        public override string ToString()
                {
                    return string.Format("A: {0}{5}, B: {1}{5}, C:{2}{5}, Típus:{6} Terület:{3}{5}2, Kerulet: {4}{5}", a,b,c,Terulet,Kerulet,mertekegyseg,tipus);
                }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Haromszog tetszoleges = new Haromszog(3,4,5,"derékszögű","km");
            Haromszog szabalyos = new Haromszog(6);

            Console.WriteLine(tetszoleges.Kerulet);
            Console.WriteLine(szabalyos.Kerulet);

            Console.WriteLine(tetszoleges.Terulet);
            Console.WriteLine(szabalyos.Terulet);

            Console.WriteLine(tetszoleges.ToString());
            Console.WriteLine(szabalyos.ToString());

            Console.WriteLine(JsonConvert.SerializeObject(tetszoleges));
            
            
        }

    }
}

