namespace alpot
{
    class Ciklus
    {
        static void Main(string[] args)
        {
            int db = 0;
            int legtobb = 0;
            for(int i = 0; i<10;i++){
                Console.WriteLine($"Hány hulló csillagot látott Pista a(z) {i+1}. órában?");
                int csillag = Convert.ToInt32(Console.ReadLine());
                if(csillag > legtobb){
                    legtobb = csillag;
                }
                db += csillag;
            }
            Console.WriteLine($"Összesen {db} hullócsillagot látott Pista, egy órába a legtöbb {legtobb} volt");
        }
    }
}

