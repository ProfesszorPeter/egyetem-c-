using Newtonsoft.Json;
namespace felev2
{
    class Fa
    {
        public string Nev;
        public string faj;
        public int kormeret;
        public string telepules;
        public int meres;

    }
    class Program
    {
        public static void Main(string[] args)
        {
            List<Fa> adatok = new List<Fa>();
            StreamReader forras = new StreamReader("fak.json");
            string forrassor = forras.ReadToEnd();
            adatok = JsonConvert.DeserializeObject<List<Fa>>(forrassor);

            foreach (var elem in adatok) {
                Console.WriteLine("{0} {1} | {2} {3} {4}",elem.Nev, elem.faj, elem.kormeret, elem.telepules, elem.meres);
            }
        }

    }
}

