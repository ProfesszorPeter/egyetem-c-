namespace felev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pont p1 = new Pont(5,2);
            Pont p2 = new Pont(-1,3);
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());

            Pont osszeg = p1 + p2;
            Console.WriteLine(osszeg.ToString());

            Pont kivonas = p1-p2;
            Console.WriteLine(kivonas.ToString());
        }
    }
}
