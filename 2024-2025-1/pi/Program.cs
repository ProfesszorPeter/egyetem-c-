
namespace pieucler
{

    class Program{

        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg, hogy hány darab számjegyet szeretne látni: ");
            int db = Convert.ToInt16(Console.ReadLine());

            double pii = 1;

            for(int i=1;i<=db;i++)
            {
                Console.WriteLine("az i: {0}",i);
                pii = pii + 1.0/i*i;
                Console.WriteLine("a pii: {0}",pii);


            }
            Console.WriteLine($"A pi értéke: {Math.Sqrt(pii*6)}");

        }
    }   
}

