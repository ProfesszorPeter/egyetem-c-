using Newtonsoft.Json;
namespace felev2
{
    class Repter
    {
        class Adatsor
        {
            public int sorszam;
            public string nev;
            public int hossz;
            public int szelesseg;
            public string anyag;
            public string ToString() { return $"{sorszam,3} {nev,40} {hossz,5} {szelesseg,4} {anyag,6}"; }
            public string ToJson(){
                return JsonConvert.SerializeObject(this, Formatting.Indented);
            }

        }

        static List<Adatsor> adatok = new List<Adatsor>();

        static void Main(string[] args)
        {
            feladat1();
            kiir();
            int db = feladat2("Budapest-Ferihegy");
            Console.WriteLine("A legtöbb kifutó {0} db/reptér",db);

            string maxNev = maxPalyahossz();
            Console.WriteLine("A leghoszabb pálya {0}-en található ",maxNev);

            anyagKeszit("beton");
            anyagKeszitFu("fű");
        }

        private static void anyagKeszitFu(string beAnyag) {
            StreamWriter fu = new StreamWriter("fu.json");
            List<Adatsor> seged = new List<Adatsor>();
            foreach (var item in adatok) {
                if (item.anyag == beAnyag) {
                    seged.Add(item);
                }
            }
            fu.WriteLine("[\n{0}\n]",String.Join(",\n",seged));
            fu.Close();
        }

        private static void anyagKeszit(string beAnyag) {
            StreamWriter ki = new StreamWriter("anyag.json");
            List<string> seged = new List<string>();
            foreach (var item in adatok) {
                if (item.anyag == beAnyag) {
                    seged.Add(item.ToJson());
                }
            }
            ki.WriteLine("[\n{0}\n]",String.Join(",\n",seged));
            ki.Close();
        }


        private static string maxPalyahossz() {
            int maxHossz = 0;
            string maxNev = "";
            foreach (var item in adatok) {
                if (maxHossz < item.hossz) {
                    maxHossz = item.hossz;
                    maxNev = item.nev;
                }
            }
            return maxNev;
        }



        private static int feladat2(string beNev) {
            
            int db = 0;
            foreach (var item in adatok) {
                if (item.nev == beNev) {
                    db++;
                }
            }
            return db;
        }


        private static void kiir()
        {
            foreach (var item in adatok)
            {
                Console.WriteLine(item.ToString());
            }
        }
        private static void feladat1()
        {

            try
            {
                StreamReader jsonFile = new StreamReader("palyak.json");
                string jsonString = jsonFile.ReadToEnd();
                jsonFile.Close();
                adatok = JsonConvert.DeserializeObject<List<Adatsor>>(jsonString);
            }
            catch (Exception e)
            {
                Console.WriteLine("Hiba: " + e.Message);
            }
        }
    }
}
