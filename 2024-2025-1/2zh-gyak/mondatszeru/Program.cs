namespace zh2
{
    class Program
    {
        static void Main(string[] args)
        {
            int db = 0;
            int osszeg = 0;
            int szam;
            do
            {
                Console.WriteLine("Adjon meg egy számot: ");
                szam = Convert.ToInt32(Console.ReadLine());
                if(szam <= -20)
                {
                    db ++;
                    osszeg = osszeg + szam;

                }

            }
            while (szam !=0);
            if(db == 0)
            {
                Console.WriteLine("Nem volt ilyen szám!");
            }
            else
                Console.WriteLine($"A számok átaga: {osszeg/db}");

        }
    }
}

