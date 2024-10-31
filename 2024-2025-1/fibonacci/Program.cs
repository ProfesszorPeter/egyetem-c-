namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fib(100));

            static int fib(int n)
            {
                if(n>1)
                {
                    return fib(n-2) + fib(n-1);
                }
                else
                {
                    return 1;
                }

            }
        }
    }
}

