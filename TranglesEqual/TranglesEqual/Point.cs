using System;
namespace TranglesEqual
{
    public class Point
    {
        public int x;
        public int y;
        public Point(int x1, int y1) //constuctor
        {
            x = x1;
            y = y1;
        }
        public override string ToString()
        {
            return "x= " + x + "y= " + y;
        }

    }
}
