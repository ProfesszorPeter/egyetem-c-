using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piLeibniz2024
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.Write("Kérem a darabszámot: ");
            int db = Convert.ToInt32(Console.ReadLine());
            int elojel = 1;
            bool e = true;
            double piii = 0;
            for (int i = 1; i < 2*db + 1; i=i+2)
            {
                //1. mego
                // Console.WriteLine(elojel* 1.0/i);
                piii = piii + elojel * 1.0 / i;
                elojel = -1 * elojel;
                //2. mego
                if(e==true)
                    Console.WriteLine(1.0 / i);
                else
                    Console.WriteLine(- 1.0 / i);
                e = !e;
                //3. mego
                if(i%4==1)
                    Console.WriteLine(1.0 / i);
                else
                    Console.WriteLine(-1.0 / i);
            }
            Console.WriteLine($"Számolt érték: {piii*4}");
            Console.ReadKey();
        }
    }
}
