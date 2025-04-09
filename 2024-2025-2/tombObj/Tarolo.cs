namespace felev2
{
    class Tarolo
    {
        private List<int> Adat = new List<int>();
        public List<int> getAdat() { return Adat; }


        public Tarolo()
        {
            Random v = new Random();
            for (int i = 0; i < 10; i++)
            {
                Adat.Add(v.Next(1, 101));
            }
        }
        public override string ToString()
        {
            return string.Join(",", Adat);
        }

        public int MaxElem()
        {
            int MaxErtek = Adat[0];
            foreach (var elem in Adat)
            {
                if (MaxErtek < elem)
                {
                    MaxErtek = elem;
                }
            }
            return MaxErtek;
        }

        public int osszErtek()
        {
            int ossz = 0;
            for (int i = 0; i < Adat.Count; i++)
            {
                ossz = ossz + Adat[i];
            }
            return ossz;
        }

        public bool oszthato5el()
        {
            int i = 0;
            while (i < Adat.Count && Adat[i] % 5 != 0)
            {
                i++;
            }
            if (i < Adat.Count)
                return true;
            else
                return false;
        }

        public int parosDB()
        {
            int db = 0;
            foreach (int elem in Adat)
            {
                if (elem % 2 == 0)
                    db++;
            }
            return db;
        }

        public List<int> paratlanok()
        {
            List<int> seged = new List<int>();
            foreach (int elem in Adat)
            {
                if (elem % 2 == 1)
                {
                    seged.Add(elem);
                }
            }
            return seged;

        }

        public List<int> szetvalogatas()
        {
            List<int> seged = Adat;

            int x = seged[0];
            int E = 0;
            int U = seged.Count - 1;

            while (E < U)
            {
                while (E < U && seged[U] >= x)
                {
                    U--;
                }
                if (E < U)
                {
                    seged[E] = seged[U];
                    E++;
                }
                while (E < U && seged[E] <= x)
                {
                    E++;
                }
                if (E < U)
                {
                    seged[U] = seged[E];
                    U--;
                }
            }
            seged[E] = x;
            return seged;
        }

        public void indexRendezes()
        {
            int[] index = new int[Adat.Count];
            //feltöttés
            for (int i = 0; i < Adat.Count; i++)
            {
                index[i] = i;
            }
            for (int j = 0; j < Adat.Count - 1; j++)
            {
                for (int i = 0; i < Adat.Count - j -1; i++)
                {
                    if (Adat[i] > Adat[i + 1])
                    {
                        int temp = Adat[i];
                        Adat[i] = Adat[i + 1];
                        Adat[i + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < Adat.Count; i++)
            {
                Console.Write($"{Adat[index[i]]} ");
            }
            Console.WriteLine();
        }


        public int felettiMaxSorozatHossz(int ertek) 
        {
            int sorozat = 0;
            int MaxHossz = 0;
            for (int i = 0; i < Adat.Count; i++)
            {
                if (Adat[i] > ertek)
                {
                    sorozat++;
                }
                else
                {
                    sorozat = 0;
                }

                if (sorozat > MaxHossz)
                {
                    MaxHossz = sorozat;
                }
            }
            return MaxHossz;
        }

    }
}

