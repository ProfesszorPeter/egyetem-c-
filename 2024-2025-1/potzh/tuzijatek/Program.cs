namespace potzh
{
  class Tuzijatek
  {
    struct Adatok
    {
      public string nev;
      public int ora;
      public int tuzijatek;
      public int petarda;
    }
    static Adatok[] a = new Adatok[5];
    static int db = 0;

    static void Main(string[] args){
      StreamReader adatok = new StreamReader("input.txt");
      while(adatok.EndOfStream == false){
        string sor = adatok.ReadLine();
        Console.WriteLine(sor);
        string[] reszek = sor.Split(";");

        Adatok x;
        x.nev = reszek[0];
        x.ora = Convert.ToInt16(reszek[1]);
        x.tuzijatek = Convert.ToInt16(reszek[2]);
        x.petarda = Convert.ToInt16(reszek[3]);
        a[db] = x;
        db ++;
      }

      feladat1();
      feladat2();
      feladat3();
      feladat4();
      feladat5();

    }

    private static void feladat5(){
      StreamWriter peter = new StreamWriter("peter.txt");
      for(int i = 0; i< db ; i++){
        Adatok x = a[i];
        if(x.nev == "Péter"){
        peter.Write($"{x.nev} {x.ora} {x.tuzijatek} {x.petarda}\n");
        }
      }
      peter.Close();
    }
    private static void feladat4(){
      int legtobb_tuzijatek = 0;
      int legtobb_ora = 0;
      for(int i = 0; i<db; i++){
        Adatok x = a[i];
        if(x.tuzijatek> legtobb_tuzijatek){
          legtobb_tuzijatek = x.tuzijatek;
          legtobb_ora = x.ora;
        }
      }
      Console.WriteLine($"{legtobb_ora} órakkor volt a legtöbb tüzijáték");
    }

    private static void feladat3(){
      int tuzijatekdb = 0;
      int petardadb = 0;
      for(int i = 0; i<db;i++){
        Adatok x = a[i];
        tuzijatekdb += x.tuzijatek;
        petardadb += x.petarda;
      }
      Console.WriteLine($"{petardadb} db petárdát, és {tuzijatekdb} db tüzijátékot láttak.");

    }

    private static void feladat2(){
        int tobb = 0;
      for(int i = 0; i<db; i++){
        Adatok x = a[i];
        if(x.tuzijatek < x.petarda){
          tobb++;
        }
      }
      Console.WriteLine($"{tobb} alkalommal hallottak több petárdát mint tüzijátékot");
    }

    private static void feladat1(){
      for(int i = 0;i<db; i++){
        Adatok x = a[i];
        if(x.ora == 10){
          Console.WriteLine($"{x.tuzijatek} tuzijátékot, {x.petarda} db petárdát látott {x.nev}, {x.ora} órakkor");
        }
      }
    }
  }
}
