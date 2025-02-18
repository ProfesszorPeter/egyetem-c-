namespace ttiallomany
{
  class Program
  {
    struct Ember
    {
      public string nev;
      public int magassag;
      public double kg;
    }

    static Ember[] e = new Ember[20];
    static int db = 0;

    static void Main(string[] args)
    {

      StreamReader be = new StreamReader("./bin/Debug/TTI.txt");

      while(be.EndOfStream == false)
      {
        string sor = be.ReadLine();
        Console.WriteLine(sor);
        string [] reszek = sor.Split(";");

        Ember x;
        x.nev = reszek[0];
        x.magassag = Convert.ToInt32(reszek[1]);
        x.kg = Convert.ToDouble(reszek[2]);
        e[db] = x;
        db ++;

        be.Close();
      }
      feladat2();
      feladat3(24);
    }

    private static void feladat2()
    {
      //irassuk ki az egyes emberek tti értékeit:
      //pl: Kis Anna: 23.4

      for(int i = 0; i<db; i++)
      {
        Ember x = e[i];
        double tti = x.kg/Math.Pow(x.magassag/100.0,2);
        Console.WriteLine($"{x.nev,15}: {tti:f2}");

      }
    }

    private static void feladat3(int hatar)
    {
      //Adott érték felettiek neveit írjuk felett.txt állományba
      StreamWriter ki = new StreamWriter("felett.txt");
      for(int i = 0; i<db; i++)
      {
        Ember x = e[i];
        double tti = x.kg/Math.Pow(x.magassag/100.0,2);
        if(tti>hatar)
          ki.WriteLine($"{x.nev,15}: {tti:f2}");

      }
      ki.Close();


    }




  }
}

