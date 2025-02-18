namespace ketto
{
  class Szoctam
  {

    static void Main(string[] args)
    {
      string[] nevek = {"Steinpilz László",
        "Kántor Endre",
        "Bartus Péter",
        "Fehér Péter",
        "Jász Gábor",

      };
      int[,] adatok = {
        {150, 220, 20, 4 },
        {200, 190, 50, 3 },
        {110, 100, 0, 5 },
        {150, 250, 60, 3 },
        {200, 200, 55, 4 },
      };

      KIIR(1);
      //Kérjük be egy diák sorszámát és írassuk ki az összes keresetét! Ügyelj rá, hogy a felhasználó 1-től kezdi a számozást!
      Console.WriteLine("Adja meg egy gyermek sorszámát: ");
      int sorszam = Convert.ToInt16(Console.ReadLine());
      Console.WriteLine($"Az összes kereset: {adatok[sorszam - 1, 0] + adatok[sorszam - 1, 1] + adatok[sorszam - 1, 2]}");

      KIIR(2);
      //Írassuk ki az egy főre eső keresetet diákonként!
      for (int i = 0; i < 5; i++)
      {
        Console.WriteLine($"{i + 1}. gyermek: {adatok[i, 0] + adatok[i, 1] + adatok[i, 2] / adatok[i, 3]}");
      }

      KIIR(3);
      //Írassuk ki, hogy hány anya keres 200 000 Ft felett!
      int tobb = 0;
      for (int i = 0; i < 4; i++)
      {
        if (adatok[i, 1] > 200)
        {
          tobb++;
        }
      }
      Console.WriteLine($"{tobb} anyuka keres 200 000 ezer fölött");

      KIIR(4);
      //Írassuk ki a alacsonyabb egy főre jutó keresetet, és azt, hogy ki(k) érte(ék) el!
      float min = 0;
      int szam = 0;
      string nev = null;
      for (int i = 0; i < 5; i++)
      {
        if (min > adatok[i, 0] + adatok[i, 1] + adatok[i, 2] / adatok[i, 3])
        {
          min = adatok[i, 0] + adatok[i, 1] + adatok[i, 2] / adatok[i, 3];
          szam = i;
          nev = nevek[i];
        }
      }
      Console.WriteLine($"{nev}-nél a legkisebb az egy főre jutó kereset: {min}");
    }
    private static void KIIR(int x)
    {
      Console.WriteLine($"\n{x}. feladat\n");
    }
  }
}
