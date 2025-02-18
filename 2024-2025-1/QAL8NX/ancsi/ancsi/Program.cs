using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ancsi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tuzijatekok = { 5, 12, 14, 25, 30, 14 };
            int ossz = 0;
            for (int i = 0; i < tuzijatekok.Length; i++)
            {
                ossz += tuzijatekok[i];
            }
            Console.WriteLine($"Összesen {ossz} tüzijátékot látott.");
            Console.ReadKey();
        }
    }
}
