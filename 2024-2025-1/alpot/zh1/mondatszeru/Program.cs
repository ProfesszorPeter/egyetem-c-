namespace alpot
{
    class mondatszeru
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[10];
            int osszeg = 0;
            int szorzat = 1;

            for(int i = 0; i<szamok.Length;i++){
                szamok[i] = i+1;
            }
            for(int i = 0; i<szamok.Length;i++){
                osszeg += szamok[i];
                szorzat *=szamok[i];
            }
            Console.WriteLine($"Az elemek összege: {osszeg}");
            Console.WriteLine($"Az elemek szorzata: {szorzat}");
            Console.WriteLine($"Az elemek átlaga: {osszeg/10}");
                

        }
    }
}

