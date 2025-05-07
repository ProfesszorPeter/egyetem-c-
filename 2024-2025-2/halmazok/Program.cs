namespace felev2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int> { 3, 40, 22, 33, 41, 5, 67, 8 };
            List<int> b = new List<int> { 2, 10, 12, 13, 5, 7, 8, 18, 67 };

            #region metszet
            List<int> c = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                bool van = false;
                for (int j = 0; j < b.Count && !van; j++)
                {
                    if (a[i] == b[j])
                    {
                        c.Add(a[i]);
                        van = true;
                    }
                }
            }
            Console.WriteLine(string.Join(",", c));

            #endregion

            #region unio
            List<int> unio = new List<int>();
            foreach (int elem in a)
            {
                unio.Add(elem);
            }
            foreach (int elem in b)
            {
                if (!unio.Contains(elem))
                {
                    unio.Add(elem);
                }
            }
            Console.WriteLine(string.Join(",", unio));

            #endregion

            #region összefuttatás tétele
            List<int> t1 = new List<int>() {2,3,7,9,10,16,34,54,66,74};
            List<int> t2 = new List<int>() {-2,13,20,29,30,34,39,99};
            List<int> ered = new List<int>();

            t1.Add(int.MaxValue);
            t2.Add(int.MaxValue);
            //végére tesszük a +végtelent(legnagyobb int érétket) hogy minden bele kerüljön

            int elsoIndex = 0;
            int masikIndex = 0;
            for (int i = 0; i<t1.Count + t2.Count - 2; i++)
            {
                if (t1[elsoIndex] < t2[masikIndex])
                {
                    ered.Add(t1[elsoIndex]);
                    elsoIndex++;
                }
                else
                {
                    ered.Add(t2[masikIndex]);
                    masikIndex++;
                }
            }
            Console.WriteLine(string.Join(",",ered));
            #endregion
        }
    }
}
