using System;
namespace TranglesEqual
{
    public class Triangle
    {
        Point a;
        Point b;
        Point c;
        double side1;
        double side2;
        double side3;
        public Triangle(Point a1, Point b1,Point c1)
        {
            a = a1;
            b = b1;
            c = c1;
            double side1 = Math.Sqrt((a1.x - b1.x)*(a1.x - b1.x)+ (a1.y - b1.y)*(a1.y - b1.y));
            double side2 = Math.Sqrt((b1.x - c1.x) * (b1.x - c1.x) + (b1.y - c1.y) * (b1.y - c1.y));
            double side3 = Math.Sqrt((a1.x - c1.x) * (a1.x - c1.x) + (a1.y - c1.y) * (a1.y - c1.y));
        }
        

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Triangle m = obj as Triangle; // return null if object isnt a triangle
            if (m as Triangle == null)
                return false;
            



            return (m.side1 == this.side1 && m.side2 == this.side2 && m.side3 == this.side3)||
                (m.side1 == this.side1 && m.side2 == this.side3 && m.side3 == this.side2)||
                (m.side1 == this.side2 && m.side2 == this.side1 && m.side3 == this.side3)||
                (m.side1 == this.side2 && m.side2 == this.side3 && m.side3 == this.side1)||
                (m.side1 == this.side3 && m.side2 == this.side2 && m.side3 == this.side1)||
                (m.side1 == this.side3 && m.side2 == this.side1 && m.side3 == this.side2);
        }
        
    }
}
