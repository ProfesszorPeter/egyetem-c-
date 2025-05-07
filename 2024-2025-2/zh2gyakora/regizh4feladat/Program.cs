namespace felev2
{
	class Program
	{
        class Kocka
        {
            public int a {get; set;}
            public int b {get; set;}
            public int c {get; set;}

            public Kocka()
            {
                this.a = 10;
                b = 10;
                c = 10;
            }

            public Kocka(int _a, int _b, int _c)
            {
                // a this opcionális
                this.a = _a;
                b = _b;
                c = _c;
            }

            public override string ToString()
            {
                return $"a:{a}, b:{b}, c:{c}";
            }

            public static Kocka operator ++(Kocka a)
            {
                Kocka eredmeny = new Kocka();
                eredmeny.a = a.a+1;
                eredmeny.b = a.b+1;
                eredmeny.c = a.c+1;
                return eredmeny;
            }


            public static Kocka operator --(Kocka a)
            {
                Kocka eredmeny = new Kocka();
                eredmeny.a = a.a-1;
                eredmeny.b = a.b-1;
                eredmeny.c = a.c-1;
                return eredmeny;
            }

        }
		static void Main(string[] args)
        {
            Kocka i = new Kocka(10, 20, 30);
            Kocka j = new Kocka();
            i++;
            j--;
            Console.WriteLine(i.ToString());
            Console.WriteLine(j.ToString());
        }
	}
}

