namespace felev2
{
    class Pont
    {
        public int X{get;}
        public int Y{get;}

        public Pont (int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }
        public static Pont operator+(Pont a, Pont b)
        {
            return new Pont(a.X+b.X,a.Y+b.Y);
        }

        public static Pont operator-(Pont a, Pont b)
        {
            return new Pont(a.X-b.X,a.Y-b.Y);
        }

        public override string ToString()
        {
            return String.Format("X={0}, Y={1}",X,Y);
        }
    }

}
