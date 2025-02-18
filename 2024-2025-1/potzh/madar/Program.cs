namespace potzh
{
    class Madar
    {
        static void Main(string[] args)
        {
            string[] fajta = {"Cinke", "S.Rigó", "Fecske", "Galamb", "Egyéb"};

            int[,] darab = {
                {4, 3, 2, 1, 4},
                {0, 3, 4, 2, 3},
                {3, 0, 2, 1, 2},
                {0, 1, 0, 3, 2},
                {3, 4, 4, 5, 0},
            };
            for(int i = 0; i<fajta.Length;i++){
                Console.Write($"\t{fajta[i]}\t");
            }
            Console.WriteLine();

            for(int i = 0; i<fajta.Length;i++){
                Console.Write($"{i+1}.tanuló:");
                for(int j = 0; j<fajta.Length;j++){
                    Console.Write($"\t{darab[i,j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Adja meg egy tanuló sorszámát: ");
            int tanulo = Convert.ToInt32(Console.ReadLine())-1;
            for(int i = 0; i<fajta.Length;i++){
                Console.Write(darab[tanulo,i]+ "\t");
            }
            Console.WriteLine();
            Console.WriteLine("3.feladat. Fecske:");
            for(int i = 0; i<fajta.Length;i++){
                Console.Write(darab[i,2]+ "\t");
            }
            bool latott = true;
            for(int i = 0; i<fajta.Length;i++){
                latott = true;
                for(int j = 0; j<fajta.Length;j++){
                    if(darab[j,i] == 0){
                        latott = false;
                        break;
                    }
                }
            }

            Console.WriteLine();
            if(!latott){
                Console.WriteLine("volt olyan madár amit mindenki látott");
            }
            else{
                Console.WriteLine("nem volt olyan madár amit mindenki látott");
            }

            double osszeg = 0;
            for(int i = 0; i<fajta.Length;i++){
                osszeg = 0;
                for(int j = 0; j<fajta.Length; j++){
                    osszeg = osszeg + darab[i,j];
                }
                Console.WriteLine($"{i+1}. tanuló: {osszeg/fajta.Length}");
            }
        }
    }
}
