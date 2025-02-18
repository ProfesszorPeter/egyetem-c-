namespace pot2
{
  class Mondoka
  {
    static void Main(string[] args) {
      int db= 0;
      int sorok = 0;
      string[,] versek = new string[db, sorok];
      StreamReader adatok = new StreamReader("mondoka.txt");
      string sor = adatok.ReadLine();
      while(sor != null){
        sor = adatok.ReadLine();
        sorok++;
        if(!sor.Contains("----")){
          versek[db,sorok] = sor;
        }
        else{
          db++;
          sorok = 0;
        }
      }
      foreach(string vers in versek){
      Console.WriteLine(versek);
      }
    }
    }
  }

