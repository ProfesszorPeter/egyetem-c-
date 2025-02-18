namespace potzh
{
    class Tetraeder
    {
        static void Main(string[] args)
        {
            int oldal = 3;
            double V = (Math.Pow(oldal,3)/12*Math.Sqrt(2));
            double A = Math.Pow(oldal,2)*Math.Sqrt(3);
            Console.WriteLine($"{oldal} hosszúság esetén a felszín {A}, a térfogat pedig {V}");
        }
    }

}
