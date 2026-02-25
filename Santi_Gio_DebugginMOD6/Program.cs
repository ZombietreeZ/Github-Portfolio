// Giovanni J. Santiago
// 
//
//
//

#region Using directives 

#endregion 

namespace Classes
{
    class Program
    {

        static void Main(string[] args)
        {
            Point origin = new Point();
            Point bottomRight = new Point(1366, 768); // no such thing as "another" in front of point, changed to "new"
            double distance = origin.DistanceTo(bottomRight);
            Console.WriteLine("Distance is: {0}", distance);
            Console.WriteLine("Number of Point objects: {0}", Point.ObjectCount());
        }
    }


    class Point
    {
        private int x, y;
        private static int objectCount = 0; // needs to be stactic

        public Point() // void is spacifice to class removing void
        {
            this.x = -1;
            this.y = -1;
            objectCount++;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            objectCount++;
        }

        public double DistanceTo(Point other) // should be public in order to call it from the program class
        {
            int xDiff = this.x - other.x;
            int yDiff = this.y - other.y;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distance;
        }

        public static int ObjectCount()
        {
            return objectCount; // needed a static in front of the int in order to fix
        }
    }
}
