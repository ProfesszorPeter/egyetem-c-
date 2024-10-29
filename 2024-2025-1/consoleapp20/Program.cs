namespace consoleapp20
{
    class Program
    {
        static void Main(string[] args)
        {
            //alporgramok
            Console.WriteLine($"Gyári eredmény: {Math.PI}");

            viete();

            double szamoltErtek = wallis(1000);
            Console.WriteLine($"A wallis-formula számolt értéke: \t{szamoltErtek}");

            double eulerErtek = euler(1000);
            Console.WriteLine($"Az euler értéke: \t{eulerErtek}");


            double eulerErtek2 = euler2(100);
            Console.WriteLine($"Az euler2 értéke: \t{eulerErtek2}");

        }

        static double euler(int db)
        {
            double pii = 0;
            for(int i = 0; i < db; i++)
            {
                pii = pii + 1.0/ ((i+1)*(i+1));


            }

            return Math.Sqrt(pii*6);
        }


        static double euler2(int db)
        {
            double pii = 0;
            for(int i = 0; i < db; i++)
            {
                pii = pii + 1.0/ Math.Pow(i=1,4);
            }

            return Math.Pow(pii*90,1.0/4);
        }


        static double wallis(int db)
        {
            double szamlalo = 2;
            double nevezo = 1;
            double pii = 1;

            for(int i = 0; i<db;i++)
            {
                pii = pii * szamlalo/nevezo;
                if (i % 2 == 0)
                    nevezo = nevezo + 2;
                else
                    szamlalo = szamlalo + 2;

            }

            return pii*2;

        }


            static void viete()
            {
                double szamlalo = Math.Sqrt(2);
                double pii = 1;
                for(int i= 0; i<10;i++)
                {
                    pii =pii* szamlalo/2;
                    szamlalo = Math.Sqrt(2+szamlalo);
                }
                Console.WriteLine($"Számol teredmény: \t{2/pii}");
            }
        
    }
}

