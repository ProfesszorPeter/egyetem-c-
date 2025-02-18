namespace zh2
{
    class Prog
    {
        static void Main(string[] args)
        {
            int[] pontok = new int[14];
            for(int i = 0; i<=pontok.Length-1; i++)
            {
                Random pont = new Random();
                pontok[i] = pont.Next(151);

            }
            int kevesebb = 0;
            for(int i = 0; i<= pontok.Length-1;i++)
            {
                Console.WriteLine(pontok[i]);
                if(pontok[i] <50)
                {
                    kevesebb++;

                }
            }
            Console.WriteLine($"{kevesebb} napon volt kevesebb pont mint 50.");
        }
    }
}

