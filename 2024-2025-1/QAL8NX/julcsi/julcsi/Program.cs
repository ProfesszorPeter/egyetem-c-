using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace julcsi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] petardak = new int[10];
            Random random = new Random();
            int ossz = 0;
            Console.WriteLine(petardak.Length);
            for (int i = 0; i < petardak.Length; i++)
            {
                petardak[i] = random.Next(5, 17);
                Console.WriteLine(petardak[i]);
                ossz += petardak[i];
            }
            Console.WriteLine("Összesen {0} petárdát hallott Julcsi.",ossz);
            Console.ReadKey();
        }
    }
}
