namespace alpot
{
    class Madar
    {
        static void Main(string[] args)
        {
            string[] madarak = {"Cinke", "SárgaRigó", "Fecske", "Galamb", "Egyéb"};
            int[,] ertekek = {
                {4, 3, 2, 1, 4},
                {0, 3, 4, 2, 3},
                {3, 0, 2, 1, 2},
                {0, 1, 0, 3, 2},
                {3, 4, 4, 5, 0}
            };
            //for(int i= 0; i<madarak.Length;i++){
            //    Console.Write($"{madarak[i]}\t");
            //}
            //for(int i= 0; i<madarak.Length;i++){
            //    for(int j= 0; j<5;j++){
            //        Console.WriteLine($"{ertekek[j,i]}\t");
            //    }
            //}
            Console.WriteLine("Adja meg egy tanuló sorszámát: ");
            int tanulo = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i<5;i++){
                if(i+1 == tanulo){
                    for(int j = 0; j<5;j++){
                        Console.Write($"{ertekek[i,j]}");
                    }
                }
            }
            Console.WriteLine();
            for(int i = 0; i<5;i++){
                if(i == 2){
                    for(int j = 0;j<5; j++){
                        Console.Write(ertekek[j,i]);
                    }

                }
            }
            Console.WriteLine();
            bool vane = false;
            for(int i = 0; i<5;i++){
                    for(int j = 0;j<5; j++){
                        if(ertekek[i,j] == 0){
                            vane = true;
                        }
                    }
            }
            if(vane){
                Console.WriteLine("nincs olyan madár amit mindenki látott");
            }
            else{
                Console.WriteLine("van olyan madár amit mindenki látott");
            }
            }
        }
    }
