namespace Gyakorlas
{
  class Program
  {
    struct Book
    {
      public string cim;
      public string szerzo;
      public int oldalak;
      public bool elerheto;
    }

    static void Main(string[] args)
    {
      Book[] konyvek = new Book[3];
      Book konyv;
      konyv.cim = null;
      konyv.szerzo = null;
      konyv.oldalak = 0;
      konyv.elerheto = true;

      for (int i = 0; i < 3; i++)
      {
        Console.WriteLine($"Adja meg az {i + 1}. könyv címét: ");
        konyv.cim = Console.ReadLine();
        Console.WriteLine($"Adja meg az {i + 1}. könyv szerzőjét: ");
        konyv.szerzo = Console.ReadLine();
        Console.WriteLine($"Adja meg az {i + 1}. könyv oldalszámát: ");
        konyv.oldalak = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Elérhető ez a könyv?(tru/false): ");
        konyv.elerheto = Convert.ToBoolean(Console.ReadLine());
        konyvek[i] = new Book();
      }
      for(int i = 0; i<3; i++) {
      Console.WriteLine(konyv.cim[i]);
      }
    }
  }
}
