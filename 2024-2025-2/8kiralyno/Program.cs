namespace felev2
{
	class Program
	{
		static void Main(string[] args)
		{
            Kiralyno(1);
            static void Kiralyno(int x)
            {
                if (x<int.MaxValue)
                {
                    Kiralyno(x);
                    Console.WriteLine(x);
                    Kiralyno(x+1);
                }
            }
		}
	}
}

