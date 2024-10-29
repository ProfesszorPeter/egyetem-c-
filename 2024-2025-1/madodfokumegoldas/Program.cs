namespace masodfokumegoldas
{
    class Program
    {
        static void Main(string[] args)
        {
            double mego1, mego2;
            masodfoku(1,2,1, out mego1, out mego2);
            Console.WriteLine($"x1 = {mego1}, x2 = {mego2}");
        }
        static void masodfoku(double a, double b, double c, out double x1, out double x2)
        {
            x1 = (-b+Math.Sqrt(b*b-4*a*c)) / (2*a);
            x2 = (-b-Math.Sqrt(b*b-4*a*c)) / (2*a);

        }
    }
}

