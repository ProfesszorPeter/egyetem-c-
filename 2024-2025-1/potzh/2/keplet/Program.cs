namespace ketto
{
  class Keplet
  {

    static void Main(string[] args) {
      bool test = osszeadasEllenorzese(3,4,7);
      Console.WriteLine(test);
      double terfogat;
      double felszin;
      henger(3,5,out terfogat, out felszin);
      Console.WriteLine($"V: {terfogat}\nA: {felszin}");
    }
    private static bool osszeadasEllenorzese(int a, int b, int c){
      if(a+b==c){
        return true;
      }
      else{
        return false;
      }
    }
    private static void henger(int sugar, int magassag, out double terfogat, out double felszin){
      terfogat = Math.Pow(sugar,2)*Math.PI*magassag;
      felszin = 2*Math.Pow(sugar,2)*Math.PI+2*sugar*magassag*Math.PI;
    }
  }
}
