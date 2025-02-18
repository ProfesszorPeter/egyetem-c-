using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzoegesadatokKezelese
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Szeretek programozni!";
            Console.WriteLine("Nagyon " + s + "(CSharpban)" );
            Console.WriteLine(String.Concat("Nagyon ", s , "(CSharpban)"));
            //Törlés
            Console.WriteLine(s.Remove(5, 3));
            //Beszurás
            Console.WriteLine(s.Insert(9,"CSharpban "));
            //Hossz
            Console.WriteLine(s.Length);
            //felesleges nem nyomtatandó karaketerek levágása
            string s2 = "  Maci Laci    ";
            Console.WriteLine(s2.Length);
            Console.WriteLine(s2.TrimStart().Length);
            Console.WriteLine(s2.TrimEnd().Length);
            Console.WriteLine(s2.Trim().Length);
            Console.WriteLine(s2.Trim());
            //Keresés
            Console.WriteLine(s.IndexOf("retek"));
            //-1-et kapok ha nincs benne
            Console.WriteLine(s.LastIndexOf("r"));
            Console.WriteLine(s.Contains("retek"));
            //vagy
            Console.WriteLine(s.IndexOf("retek")>=0);
            //csere , valamit, valamire
            Console.WriteLine(s.Replace("r","R"));
            //nagy-kicsi
            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s.ToLower());
            //részképzés
            Console.WriteLine(s.Substring(9));
            string nevem = "Gugolya László";
            int szokoz = nevem.IndexOf(" ");
            Console.WriteLine("Vezetéknevem: " + nevem.Substring(0,szokoz));
            Console.WriteLine("Keresznevem: "+ nevem.Substring(szokoz+1));
            //vágás
            string[] reszek = s.Split('r');
            Console.WriteLine(reszek.Length);
            for (int i = 0; i < reszek.Length; i++)
            {
                Console.WriteLine(reszek[i]);
            }
            //összefűzés: vágás ellentéte
            int[] t = { 3, 4, 33, 22, 1 };
            Console.WriteLine(String.Join(", ", t));
            Console.ReadKey();
        }
    }
}
