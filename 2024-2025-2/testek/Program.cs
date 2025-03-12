namespace felev2
{
    class Testek
    {
        static List<Gula> adatok = new List<Gula>();
        static void Main(string[] args)
        {
            Kup k1 = new Kup();
            Kup k2 = new Kup(2,4,"m");
            Console.WriteLine(k1.terfogat());
            Console.WriteLine(k2.felszin());

            Tetraeder t1 = new Tetraeder();
            Tetraeder t2 = new Tetraeder(2,"cm");
            Console.WriteLine(t1.felszin());
            Console.WriteLine(t1.terfogat());
            Console.WriteLine(t2.felszin());
            Console.WriteLine(t2.terfogat());
            Console.WriteLine(t1.ToString());
            Console.WriteLine(t2.ToString());

            adatok.Add(k1);
            adatok.Add(k2);
            adatok.Add(new Kup(12,33,"cm"));
            adatok.Add(t1);
            adatok.Add(t2);


            kiir();
            Console.WriteLine("Tetraéderek össz térfogata: {0}", osszterfogatTetraeder());

            Console.WriteLine("Kúpok alkotóinak össz hossza: {0}", hosszAlkotoKup());

        }
        static void kiir()
        {
            foreach (var x in adatok)
            {
                Console.WriteLine("Lista tartalma");
                Console.WriteLine(x.ToString());
            }
        }
        static double osszterfogatTetraeder()
        {
            double ossz = 0;
            foreach (var test in adatok)
            {
                if (test is Tetraeder)
                {
                    ossz = ossz + test.terfogat();
                }
            }
            return ossz;
        }

        static double hosszAlkotoKup()
        {
            double ossz = 0;
            foreach (var test in adatok)
            {
                if (test is Kup)
                {
                    ossz = ossz + (test as Kup).getAlkoto();
                }
            }
            return ossz;
        }
    }
}
