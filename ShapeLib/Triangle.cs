namespace ShapeLib
{
    public class Triangle : Shape
    {
        public vector2d [] Points { get; set;
        }
        
        public Triangle()
        {
            Points = new vector2d[3];
        }

        public Triangle(vector2d p0 , vector2d p1 , vector2d p2)
        {
            Points = new vector2d[3];
            Points[0] = p0;
            Points[1] = p1;
            Points[2] = p2;
        }
        public override void Draw()
        {

        }
    }


}
