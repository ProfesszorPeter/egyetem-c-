namespace felev2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mesterember m1 = new Mesterember("Kiss János", 5000);
            Burkolo b1 = new Burkolo("Nagy Imre", 5000, "Belső");
            Random v = new Random();

            for (int i = 0; i < 10; i++)
            {
                b1.Munkatvalal(v.Next(1, 31));
            }
            Console.WriteLine(b1.ToString());
            //List<Munka> adatok = new List<Munka>();
            List<Mesterember> adatok = new List<Mesterember>();
            Vizvezetekszerelo v1 = new Vizvezetekszerelo("Ügyes Antal", 12000, 25);
            Vizvezetekszerelo v2 = new Vizvezetekszerelo("Kezdő Pál", 8000, 2);
            v2.Tapasztalat = 5;
            v2.Munkatvalal(3);
            v1.Munkatvalal(3);

            adatok.Add(v1);
            adatok.Add(b1);
            adatok.Add(v2);
            adatok.Add(new Burkolo("Erős Péter", 6000, "Külső"));
            adatok.Add(new Vizvezetekszerelo("Kovács Péter", 7000, 1));

            Console.Write("Kérem a szakma megnevezését: ");
            string beSzakma = Console.ReadLine();

            foreach (var item in adatok)
            {
                if (beSzakma == "Vízvezetékszerelő" && item is Vizvezetekszerelo)
                    Console.WriteLine(item.ToString());
                if (beSzakma == "Burkoló" && item is Burkolo)
                    Console.WriteLine(item.ToString());

            }
            Mesterember maxSzabados = null;
            int maxSzabadnap = 0;
            foreach (var item in adatok)
            {
                if(item is Burkolo && maxSzabadnap < (item as Burkolo).OsszesSzabadnap())
                {
                    maxSzabadnap = (item as Burkolo).OsszesSzabadnap();
                    maxSzabados = item;
                }
            }
            Console.WriteLine(maxSzabados.ToString());
        }
    }
}
