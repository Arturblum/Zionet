using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
   public  class vector2d
    {
        public double X { get; set; }
        public double Y { get; set; }

        public vector2d()
        {
        }

        public vector2d(double x , double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X} , {Y} )";
        }

        public static vector2d operator +(vector2d a, vector2d b) => new vector2d(a.X + b.X, a.Y + b.Y);

        public static vector2d operator -(vector2d a, vector2d b) => new vector2d(a.X - b.X, a.Y - b.Y);

        public static vector2d operator *(vector2d a, double s) => new vector2d(a.X * s, a.Y * s);

        public static vector2d operator *(double s , vector2d a) => new vector2d(a.X * s, a.Y * s);

        public static vector2d operator /(double s, vector2d a) => new vector2d(a.X / s, a.Y / s);
        public static double operator *(vector2d a, vector2d b) => a.X * b.X+ a.Y * b.Y;

        public double length()
        {
            return Math.Sqrt (X * X + Y * Y);
        }

        public vector2d Normalize()
        {
            
                var l = length();

                X /= l;
                Y /= l;

            return this;
        }
    
        //v= new vector2d ("(1.2323 , -5)")
        public vector2d(string s)
        {
            
        }
    }
}
