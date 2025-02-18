namespace ketto
{
    class Gyumi
    {

        static void Main(string[] args) {
          string[] gyumik = new string[20];

          StreamReader adatok = new StreamReader("gyumi.txt");
          for(int i = 0; i<20; i++){
            gyumik[i] = adatok.ReadLine();

          }
          int nem = 0;
          for(int i = 0; i<20; i++){
            if(gyumik[i] == "-"){
              nem++;
            }
          }
          Console.WriteLine($"{nem} napon nem kaptak gyümölcsöt");

          Console.Write("Adja meg egy gyümölcs nevét: ");
          string gyumi = Console.ReadLine();
          int db = 0;
          for(int i = 0; i<20; i++){
            if(gyumik[i] == gyumi){
              db++;
            }
          }
          Console.WriteLine($"{db}-szor kaptak {gyumi}-t");

          int alma = 0;
          for(int i = 0; i<20; i++){
            if(gyumik[i] == "alma"){
              alma++;
            }
          }
          Console.WriteLine($"{alma*1.0/20*100} százalékban kaptak almát a gyerekek");

          bool UgyanAz = false;
          for(int i = 0; i<19; i++){
            if(gyumik[i] == gyumik[i+1]){
              UgyanAz = true;
            }
          }
          if(UgyanAz){
            Console.WriteLine("Volt olyan hogy két egymást követő napon ugyan azt a gyümölcsöt kapták");
          }
          else{
            Console.WriteLine("Nem volt olyan hogy két egymást követő napon ugyan azt a gyümölcsöt kapták");
          }


        }
    }
}
