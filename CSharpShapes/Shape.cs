using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CSharpShapes
{
    public class Shape
    {
        // Width, Height, Perimeter, Area, BorderColor, FillColor, NumberOfSides
        public Color FillColor { get; set; }
        public Color BorderColor { get; set; }
        public virtual int SidesCount { get; }

        // Returns the area of this shape
        public abstract decimal Area();

        // Returns the perimeter of this shape
        public abstract int Perimeter();
        
        // Resizes a shape by percent%
        public abstract void scale(int percent){ }
    }
}
