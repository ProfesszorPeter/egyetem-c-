namespace zh2
{
    class Duolingvo
    {
        static void Main(string[] args)
        {
            int[] pontok = new int[5];
            int nap = 0;
            for(int i = 1; i<=pontok.Length; i++)
            {
                Console.WriteLine($"Hány pontot szerzett az {i}. napon? (0-10): ");
                pontok[i-1] = Convert.ToInt16(Console.ReadLine());
                if(pontok[i-1] == 0)
                    nap = i;
            }
            int osszeg = 0;
            for(int i = 0; i<pontok.Length; i++)
            {
                osszeg = osszeg + pontok[i];
            }
            Console.WriteLine($"Összesen {osszeg} pontja van.");

            for(int i = 0; i<pontok.Length;i++)
            {
                if(i ==0)
                    Console.WriteLine($"Ejnye bejnye {nap}-on nem tanultál.");

            }
        }
    }
}

