namespace zh2
{
    class Pogram
    {
        static void Main(string[] args)
        {
            string[] napok = {"hétfő", "kedd", "szerda", "csütörtök", "péntek", "szombat", "vasárnap"};
            Console.WriteLine($"napok hossza: {napok.Length}");
            int[,] hetek = {
                {10,20,0,10,140,30,60},
                {70,100,10,20,50,40,50},
                {90,110,30,40,50,40,20},
                {0,120,100,60,50,0,110}
            };
            Console.WriteLine($"hetek hossza: {hetek.GetLength}");
            for(int i = 0;i<6;i++)
            {
                Console.WriteLine(hetek[i,i]);
                for(int j = 0; j<7;j++)
                {
                    Console.Write(hetek[j,i]);
                }
            }
        }
    }
}

