﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace CSharpShapes
{
    public class Trapezoid : Quadrilateral
    {
        private decimal base1;
        public decimal Base1
        {
            get { return this.base1; }
        }
        private decimal base2;
        public decimal Base2
        {
            get { return this.base2; }
        }
        private decimal height;
        public decimal Height
        {
            get { return this.height; }
        }

        public Trapezoid(int base1, int base2, int height)
        {
            if (base1 <= 0 || base2 <= 0 || height <= 0)
            {
                throw new ArgumentException();
            }
            this.base1 = base1;
            this.base2 = base2;
            this.height = height;
        }

        public override void DrawOnto(Canvas ShapeCanvas, int x, int y)
        {
            throw new NotImplementedException();
        }

        public override decimal Area()
        {
            return (base1 + base2) / 2 * height;
        }

        public override decimal Perimeter()
        {
            throw new NotImplementedException();
        }

        public override void Scale(int percent)
        {
            if (percent <= 0)
            {
                throw new NotImplementedException();
            }
            this.base1 = base1 * percent / 100;
            this.base2 = base2 * percent / 100;
            this.height = height * percent / 100;
        }
    }
}
