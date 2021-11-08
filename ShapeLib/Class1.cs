using System;
using System.Drawing;

namespace ShapeLib
{
    public abstract class Shape
    {
        public Color Color { get; set; }

        public vector2d Center { get; set; }
        public abstract void Draw();
    }


}
