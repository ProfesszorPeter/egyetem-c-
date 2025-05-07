namespace felev2
{
	class Program
	{
        class Horgaszverseny
        {
            public int PontyDB {get;set;}
            int KeszegDB {get;set;}
            int KaraszDB {get;set;}
            int HarcsaDB {get;set;}
            int AmurDB {get;set;}

            public Horgaszverseny 
        }
		static void Main(string[] args)
		{
            StreamReader adatok = new StreamReader("allomany.txt");

            List<string> lista = new List<string>();

            List<int> halak = new List<int>();

            int index = 0;
            while (!adatok.EndOfStream)
            {
                lista.Add(adatok.ReadLine());
                index++;
            }

            for (int i = 1; i < lista.Count; i = i + 2)
            {
                halak.Add(Convert.ToInt16(lista[i]));
                lista.Remove(lista[i]);
            }
		}
        private static string Kiir()
        {
            foreach (var elem in lista)
            {
                Console.WriteLine()
            }

        }
	}
}

