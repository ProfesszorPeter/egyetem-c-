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

        }
		static void Main(string[] args)
        {
            Kocka i = new Kocka(10, 20, 30);
            Kocka j = new Kocka();
            Console.WriteLine(i.ToString());
            Console.WriteLine(j.ToString());
        }
	}
}

