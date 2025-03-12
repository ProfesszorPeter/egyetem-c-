namespace felev2
{
    class Program
    {
        class Allat
        {
            protected string beszel;
            public Allat(string beBeszel)
            {
                beszel = beBeszel;
            }
            public string Kimond()
            {
                return beszel;
            }
            public virtual void jar()
            {
                Console.WriteLine("A->B");
            }
            public static void Fontos()
            {
                Console.WriteLine("Kérelek ne bántsd az állatokat");
            }
        }
        class Kutya : Allat
        {
            protected bool chip;
            public Kutya(string beBeszel, bool beChip):base(beBeszel)
            {
                chip = beChip;
                beszel += beszel;
            }
            public override void jar()
            {
                Console.WriteLine("Négy lábon rohanok");
            }
        }
        class Madar : Allat
        {
            public Madar(string beBeszel): base(beBeszel){}
            public override void jar()
            {
                Console.WriteLine("Repülök");
            }
        }
        static void Main(string[] args)
        {
            Allat kakas = new Allat("kukuriku");
            Console.WriteLine(kakas.Kimond());
            Kutya bodri = new Kutya("vau",true);
            Console.WriteLine(bodri.Kimond());
            Madar vereb = new Madar("csiripelek");

            kakas.jar();
            bodri.jar();
            vereb.jar();

            Allat.Fontos();
        }
    }
}
