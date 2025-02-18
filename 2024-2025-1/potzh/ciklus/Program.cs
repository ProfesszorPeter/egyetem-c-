namespace potzh
{
    class Ciklus
    {
        static void Main(string[] args)
        {
            int ossz = 0;
            int legtobb = 0;
            for(int i = 1; i<6; i++){
                Console.WriteLine($"Hány hullócsillagot látott a(z) {i}-edik órában?");
                int db = Convert.ToInt32(Console.ReadLine());
                ossz += db;
                if(db > legtobb){
                    legtobb = db;
                }
            }
            Console.WriteLine($"Összesen {ossz} hullócsillagot látott.");
            Console.WriteLine($"{legtobb} db hullócsillag volt a legtöbb amit egy órában látott ");
        }
    }
}
