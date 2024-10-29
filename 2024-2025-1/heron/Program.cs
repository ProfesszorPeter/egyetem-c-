namespace heron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a háromszög 1. oldalát: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adja meg a háromszög 2. oldalát: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adja meg a háromszög 3. oldalát: ");
            int c = Convert.ToInt32(Console.ReadLine());

            double s = (a+b+c)/2.0;
            double T = Math.Sqrt(s*(s-a)*(s-b)*(s-c));
            Console.WriteLine($"A háromszög területe: {T}");
        }
    }
}
