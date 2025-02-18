namespace alpot
{
    class Jegyek
    {
        static void Main(string[] args)
        {
            int[] felev = {3,4,5,4,2,3,5};
            int[] evvege = {4,5,4,5,4,4,4};

            int ront = 0;
            for(int i = 0; i<felev.Length; i++){
                if(felev[i] > evvege[i]){
                    ront++;
                }
            }
            Console.WriteLine($"{ront} tárgyból rontott.");

            int ossz = 0;
            for(int i = 0; i<evvege.Length; i++){
                ossz += evvege[i];
            }
            Console.WriteLine($"Az év végi átlag: {ossz/evvege.Length}");

            bool volt = false;
            for(int i = 0; i<felev.Length;i++){
                if(Math.Abs(felev[i]-evvege[i])>1){
                    volt = true;
                }
            }
            if(volt){
                Console.WriteLine("Volt olyan tantárgy");
            }
            else{
                Console.WriteLine("nem volt");
            }
        }
    }
}

