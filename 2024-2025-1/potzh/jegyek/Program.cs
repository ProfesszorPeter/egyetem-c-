namespace potzh
{
    class Jegyek
    {
        static void Main(string[] args)
        {
            int[] felev = {3,4,5,4,2,3,5};
            int[] evvege = {4,5,4,5,4,4,4};

            int ront = 0;
            for(int i = 0; i<felev.Length;i++){
                if(felev[i]>evvege[i]){
                    ront++;
                }
            }
            Console.WriteLine($"{ront} tárgyból rontott");
            
            int db = 0;
            for(int i = 0; i<felev.Length;i++){
                db +=felev[i];
            }
            Console.WriteLine($"A félév átlaga: {db/felev.Length}");

            bool volt = false;
            for(int i = 0;i<felev.Length;i++){
                if(Math.Abs(evvege[i]-felev[i])== 2){
                    volt = true;
                }
            }
            if(volt == true){
                Console.WriteLine("Volt olyan, hogy kettőt rontott vagy javított");
            }
            else{
                Console.WriteLine("Nem volt olyan, hogy kettőt rontott vagy javított");
            }
        }
    }
}
