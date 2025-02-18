namespace zh2
{
    class Prgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a testtömegét: ");
            int H = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adja meg a magasságát: ");
            int W = Convert.ToInt32(Console.ReadLine());
            double BSA = ()Math.Pow(W, 0.425)*Math.Pow(H, 0.725)*0.007184);
            Console.WriteLine($"A BSA indexe: {BSA}");

        }
    }
}

