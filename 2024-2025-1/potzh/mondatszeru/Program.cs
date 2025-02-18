namespace potzh
{
    class Mondatszeru
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[10];
            for(int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = i;
            }
            int osszeg = 0;
            int szorzat = 1;

            for(int i = 1;i<tomb.Length;i++){
                osszeg += i;
                szorzat *= i;
            }
            Console.WriteLine($"Az elemek összege: {osszeg}");
            Console.WriteLine($"Az elemek szorzata: {szorzat}");
            Console.WriteLine($"Az elemek átlaga: {osszeg/10}");

        }
    }

}

