namespace zh2
{
    class Progr
    {
        static void Main(string[] args)
        {
            bool var = osszeadasEllenorzes(5,6,11);
            Console.WriteLine(var);
        }
        static bool osszeadasEllenorzes(int a, int b, int eredmeny) 
        {
            if(a+b==eredmeny)
                return true;
            else
                return false;

        }
    }
}

