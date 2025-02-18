namespace alpot{
  class Buli{
    struct Adatok{
      public string Nev;
      public int viz;
      public int uccsi;
      public int sor;
      public int bor;
      public int rovid;
    }
    static Adatok[] a = new Adatok[3];
    static int db = 0;
    static void Main(string[] args){
      StreamReader adatok = new StreamReader("szilveszter2019.txt");
      string sor = adatok.ReadLine();
      int db = 0;
      while(sor != null){
        string[] reszek = sor.Split(";");

        Adatok x;
        x.Nev = reszek[0];
        x.viz = Convert.ToInt32(reszek[1]);
        x.uccsi = Convert.ToInt32(reszek[2]);
        x.sor = Convert.ToInt32(reszek[3]);
        x.bor = Convert.ToInt32(reszek[4]);
        x.rovid = Convert.ToInt32(reszek[5]);
        a[db] = x;
        db++;
        Console.WriteLine(sor);
      }
      adatok.Close();
      Console.WriteLine(a);
      for(int i = 0; i<a.Length;i++){
        Console.WriteLine(a[i]);
      }
    }
  }
}
