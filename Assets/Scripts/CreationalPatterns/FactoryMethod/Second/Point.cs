namespace Asteroids.Second
{
    internal sealed class Point
    {
        private int _x;
        private int _y;

        public Point()
        {
            
        }

        public static Point CreateWH(int w, int h)
        {
            var point = new Point();
            point._x = w;
            point._y = h;
            return point;
        }

        public static Point CreateDT(int d, int t)
        {
            var point = new Point();
            point._x = d;
            point._y = t;
            return point;
        }
    }
}
