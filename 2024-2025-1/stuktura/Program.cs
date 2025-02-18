namespace struktura
{
    class Program
    {
        public struct Ember
        {
            public string neptunkod;
            public string nev;
            public int magassag;
            public double kg;
        }
        static void Main(string[] args)
        {
            Ember x;
            x.neptunkod = "ABC.123";
            x.nev = "Kiss István";
            x.magassag = 180;
            x.kg = 84.5;
            double tti = x.kg / Math.Pow(x.magassag/100.0,2);
            Console.WriteLine($"{x.nev} testömegindexe: {tti}");

        }
    }
}

