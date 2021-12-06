using System;
namespace  DefenceGame {
    class Point {
        readonly public int X;
        readonly public int Y;
        public Point(int x, int y) {
            X = x;
            Y = y;
        }
        public int DistanceTo(int x, int y) {
            int xDiff = X - x;
            int yDiff = Y - y;

            int xDiffSquared = xDiff * xDiff;
            int yDiffSquared = yDiff * yDiff;

            return (int)Math.Sqrt(xDiffSquared + yDiffSquared);
        }
        // Method overloading. Multiple methods with same name in same class.
        public int DistanceTo(Point point) {
            return DistanceTo(point.X, point.Y);
        }
    }   
}