namespace hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            static void hanoi(int honnan, int manko, int hova, int n)
            {
                hanoi(1,2,3,3);
                if(n>=1)
                {
                    hanoi(honnan, hova, manko, n-1);
                    Console.WriteLine($"{honnan} -> {hova}");
                    hanoi(manko,honnan,hova, n-1);
                }
            }
        }
    }
}

