namespace ketto
{
    class Struktura
    {
      struct Tanulo{
        public string Nev;
        public int ApaKeres;
        public int AnyaKeres;
        public int CsaladTag;
      }

        static void Main(string[] args) {
          Tanulo t;
          Console.Write("Adja meg a tanuló nevét: ");
          t.Nev = Console.ReadLine();

          Console.Write("Adja meg a tanuló apukájának keresetét: ");
          t.ApaKeres = Convert.ToInt32(Console.ReadLine());

          Console.Write("Adja meg a tanuló anyukájának keresetét: ");
          t.AnyaKeres = Convert.ToInt32(Console.ReadLine());

          Console.Write("Adja meg hogy hány fő van a tanuló családjában: ");
          t.CsaladTag = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine($"Az egy főre jutó kereset: {1.0*t.ApaKeres+t.AnyaKeres*1.0/ t.CsaladTag}");
        }
    }
}
