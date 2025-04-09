namespace felev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tarolo t = new Tarolo();

            Console.WriteLine(t.ToString());

            Console.WriteLine("A legnagyobb elem a listában: {0}",t.MaxElem());
            Console.WriteLine("Az elemek össz értéke: {0}",t.osszErtek());

            if (t.oszthato5el())
                Console.WriteLine("Van benne 5-ös");
            else
                Console.WriteLine("Nincs benne 5-ös");

            Console.WriteLine($"Páros elemek száma: {t.parosDB()}");

            List<int> kutya = t.getAdat();
            Console.WriteLine("A második eleme: {0}", kutya[1]);

            //kiválogatás
            List<int> p = t.paratlanok();
            Console.WriteLine(string.Join("*",p));
            //szétválogatás
            List<int> sz = t.szetvalogatas();
            Console.WriteLine(string.Join("**",sz));

            //WTF valami nem jó!! miért van rendezve az eredeti listám is?? (tanárnál is)
            //rendezés
            t.indexRendezes();
            //ToString-el az eredeti adatosoromat kéne vissza kapjam
            //DE NEM JAÓÓ
            Console.WriteLine(t.ToString());


            Console.WriteLine($"Az 50 feletti sorozatok maximális hossza: {t.felettiMaxSorozatHossz(50)}");
        }
    }
    
}

