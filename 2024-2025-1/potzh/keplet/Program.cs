namespace potzh
{
    class Keplet
    {
        static void Main(string[] args)
        {
            hatomszogE(3,4,5);
            int elhossz = 3;
            double terfogat;
            double felszin;
            oktaederVA(elhossz, out terfogat, out felszin);
            Console.WriteLine($"A térfogata: {terfogat}, a felszine pedig: {felszin}");

            string szoveg = "Eszperente nyelven mekegett";
            int e = vane(szoveg);
            Console.WriteLine(e);
        }
        private static int vane(string szoveg)
        {
            szoveg.ToLower();
            int db = 1;
            if(szoveg.LastIndexOf("e")== -1)
            {
                return szoveg.LastIndexOf("e");

            }
            else
            {
                for(int betu = 0; betu<szoveg.Length;betu++)
                {
                    if(szoveg[betu] == 'e')
                    {
                        db++;
                    }
                }
                return db;
            }
        }


        private static void oktaederVA(int elhossz, out double V, out double A)
        {
            V = (Math.Pow(elhossz,3)/3)*Math.Sqrt(2);
            A = 2*Math.Pow(elhossz,2)*Math.Sqrt(3);
        }


        private static void hatomszogE(int a, int b, int c)
        {
            if(a+b>c){
                Console.WriteLine("Meg lehet szerkeszteni a háromszöet");
            }
            else{
                Console.WriteLine("Nem lehet megszerkeszteni a háromszöet");
            }
        }
    }
}
