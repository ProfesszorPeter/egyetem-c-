using Newtonsoft.Json;
namespace felev2
{
    class TtiJson
    {
        class Adatsor
        {
            public string Nev;
            public string Osztaly;
            public double kg;
            public int cm;
            int ev;
            bool ferfi;
            public int Cipo{get;set;}
            string szemszin;
            public string Szemszin{
                set
                {
                    szemszin = value;
                }
                get
                {
                    return szemszin;
                }
            }
            public void setFerfi(bool _ferfi) {ferfi = _ferfi;}
            public string getFerfi(){
                if (ferfi)
                    return "férfi";
                return "nő";
            }
            public void BeallitEv(int _ev){ev = _ev;}
            public int LekerEv(){return ev;}
            public string tti()
            {
                string v = "";
                double tti = kg / (cm * cm )* 100 * 100;
                v = Convert.ToString(tti);
                return v;
            }
            public Adatsor( string nev, double kg, int cm){
                Nev = nev;
                Osztaly = "magántanuló";
                this.kg = kg;
                this.cm = cm;
            }
        }
        static List<Adatsor> adatok = new List<Adatsor>();
        static void Main(string[] args)
        {
            StreamReader be = new StreamReader("tti.json");
            string jsonString = be.ReadToEnd();
            adatok = JsonConvert.DeserializeObject<List<Adatsor>>(jsonString);
            be.Close();
            
            Adatsor z = new Adatsor("Szép Krisztina",49, 158);
            Adatsor y = new Adatsor("Kovács József", 120, 171);
            z.BeallitEv(18);
            z.setFerfi(false);
            y.setFerfi(true);
            z.Szemszin = "Barna";
            y.Szemszin = "Kék";
            z.Cipo = 37;
            y.Cipo = 42;
            adatok.Add(z);
            adatok.Add(y);

            foreach ( var x in adatok){
                Console.WriteLine($"{x.Nev}: {x.tti()} ({x.LekerEv()}, {x.getFerfi()})");
                Console.WriteLine($"Szeme színe: {x.Szemszin}");
                Console.WriteLine($"Cipő méret: {x.Cipo}");
                Console.WriteLine();
            }
        }
    }
}
