namespace alpot
{
    class Tetraeder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a tetraéder oldalhosszát: ");
            int oldal = Convert.ToInt32(Console.ReadLine());
            double V = (Math.Pow(oldal,3)/12)*Math.Sqrt(2);
            double A = Math.Pow(oldal,2)*Math.Sqrt(3);
            Console.WriteLine($"A tetraéder felszíne: {A}, az űrtartalma pedig: {V}");
        }
    }
}

