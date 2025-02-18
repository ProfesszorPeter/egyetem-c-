namespace potzh
{
  class Toto
  {
    static int db = 0;
    static void Main(string[] args)
    {
      StreamReader adatok = new StreamReader("toto.txt");
      string sor = adatok.ReadLine();

      while(sor!= null)
      {
        db++;
        sor = adatok.ReadLine();
      }
      adatok.Close();

      string[] tippek = new string[db];

      StreamReader adat = new StreamReader("toto.txt");

      for(int i = 0; i<db; i++){
        var sorok = adat.ReadLine();
        tippek[i] = sorok;
      }
      adat.Close();

      kiirDb();
      string helyes ="211121x21x12x1";
      Console.WriteLine("A tippelő sorszáma: ");
      int tippelo = Convert.ToInt16(Console.ReadLine());
      string tipp = helyes;

      sorszamTipp(tippelo, tippek);
      sorszamHelyes(tippek, tippelo, helyes);
      feladatSzazalek(tippek, helyes);
      mindErteke(tippek, helyes);
      nyertes(helyes, tippek);
    }

    private static void nyertes(string helyes, string[] tippek){
      StreamWriter nyertes = new StreamWriter("nyertes.txt");
      for(int i = 0; i<helyes.Length; i++){
        if(ertekel(tippek[i],helyes) >=10){
          nyertes.WriteLine($"{i}: {tippek} {ertekel(tippek[i],helyes)}");
        }
      }
      nyertes.Close();
    }

    private static void mindErteke(string[] tippek, string helyes){
      for(int i = 0; i<14; i++){
       Console.WriteLine("{0}. tipp {1}", i,ertekel(tippek[i], helyes));
      }
    }

    private static int ertekel(string tipp, string helyes ){
      int talalat = 0;
      for(int i = 0; i<helyes.Length;i++){
          if(tipp[i]== helyes[i]){
            talalat++;
        }
      }
      return talalat;
    }

    private static void feladatSzazalek(string[] tippek, string helyes){
      Console.Write("\nAdja meg egy feladat sorszámát: ");
      int sorszam =Convert.ToInt16( Console.ReadLine());
      int jo = 0;
      for(int j = 0; j<helyes.Length; j++){
        if(helyes[j] == tippek[j][sorszam-1]){
          jo++;
        }
      }
      Console.WriteLine("A versenzők {0} százaléka adott helyes választ a feladatra.",100.0*jo/db);
    }

    private static void sorszamHelyes(string[]tippek, int tippelo, string helyes){
      Console.WriteLine("A helyes megoldás:");
      Console.WriteLine(helyes);

      for(int j = 0; j<helyes.Length;j++ ){
        if(helyes[j]  == tippek[tippelo-1][j]){
          Console.Write("+");
        }
        else{
          Console.Write(" ");
        }
      }
    }

    private static void sorszamTipp(int tippelo, string[]tippek) {
      Console.WriteLine("Az adott tippelő tippjei:");
      Console.WriteLine(tippek[tippelo-1]);

    }
    private static void kiirDb() {
      Console.WriteLine($"{db}-an játszottak"); 
    }
  }
}
