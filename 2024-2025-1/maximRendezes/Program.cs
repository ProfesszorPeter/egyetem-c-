namespace maxminRendezes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = {12,34,1,-4,5,21,45,2,67,44};

            //maximum kiválasztás, növekvő
            //maximum kiválasztása
            for(int j = 0; j< t.Length -1; j++)
            {
                int maxIndex = 0;

                for(int i = maxIndex +1; i<t.Length -j; i++)
                {
                    if(t[i] > t[maxIndex])
                        maxIndex = i;
                }
                //csere
                int temp = t[t.Length-1];
                t[t.Length-1] = t[maxIndex];
                t[maxIndex] = temp;
            }

            int[] t2 = {12,34,1,-4,5,21,45,2,67,44};
            for(int j = 0; j<t2.Length -1;j++)
            {
                //maximum
                int maxi = 0;
                for(int i = 0; i<t2.Length; i++)
                {
                    if(t2[i] > t2[maxi])
                        maxi = i;
                }
                //csere
                int tempi = t2[0];
                t2[0] = t2[maxi];
                t2[maxi] = tempi;
            }

            Console.WriteLine(t2[0]);

        }
    }
}

