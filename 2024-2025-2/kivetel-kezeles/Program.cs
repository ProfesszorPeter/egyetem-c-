namespace felev2
{
    class Kivetel
    {
        
        static void Main(string[] args)
            {
                //vannak veszélyes szituációk
                //eddig:
                /*
                int y = 0;
                int x = 10 / y;
                Console.WriteLine(x);
                
                int[] t = {1,2,3,4,5};
                Console.WriteLine(t[10]);

                StreamReader be = new StreamReader("kutya.txt");
                be.Close();
                */

                //megoldás
                try {
                int y = 1;
                int x = 10 / y;
                Console.WriteLine(x);

                int[] t = {1,2,3,4,5};
                Console.WriteLine(t[10]);

                }
                catch (DivideByZeroException e) {
                    Console.WriteLine(("Nullával nem osztunk te Barom"));
                    Console.WriteLine(e);
                }
                catch (IndexOutOfRangeException e) {
                    Console.WriteLine("Mindennek van egy határa...");
                    Console.WriteLine(e);
                }

                
            }
        }
    }
