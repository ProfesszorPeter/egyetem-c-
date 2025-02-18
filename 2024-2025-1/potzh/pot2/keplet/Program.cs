namespace pot2
{
  class Keplet
  {
    static void Main(string[] args) {
      bool test = MaradekosOsztasEllenorzes(13,3,4,1);
      Console.WriteLine(test);
      int elhossz = 4;
      double terfogat;
      Tetraeder(elhossz, out terfogat);
      Console.WriteLine("A Tetraeder térfogata: {0}",terfogat);
    }
    private static bool MaradekosOsztasEllenorzes(int osztando, int oszto, int hanyados, int maradek){
      if(osztando/oszto==hanyados && osztando%oszto==maradek){
        return true;
      }
      else{
        return false;
      }
    }

    private static void Tetraeder(int elhossz, out double terfogat){ 
      terfogat =(Math.Sqrt(2)/12)*Math.Pow(elhossz,3);
    }
  }
}
