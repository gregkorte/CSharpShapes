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

        /// <summary>
        /// The interior color of the shape, when drawn.
        /// </summary>
        public Color FillColor { get; set; }

        /// <summary>
        /// The border color of the shape, when drawn.
        /// </summary>
        public Color BorderColor { get; set; }

        /// <summary>
        /// The number of sides to the shape.
        /// </summary>
        public virtual int SidesCount { get; }

        /// <summary>
        /// Calculates the area of the shape.
        /// </summary>
        /// <returns>
        /// The area of the shape.</returns>
        public abstract decimal Area();

        /// <summary>
        /// Calculates the perimeter of the shape.
        /// </summary>
        /// <returns>The perimeter of the shape</returns>
        public abstract int Perimeter();

        /// <summary>
        /// Scales the shape in size.
        /// </summary>
        /// <param name="percentage">The percentage by which to scale the shape.</param>
        public abstract void scale(int percent);
    }
}
