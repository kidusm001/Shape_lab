using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Rectangle : Shape
    {
        private double length;
        private double width;
        public double Length { 
            get { return length; } 
            set { length = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public override double getArea()
        {
            return (length * width);
        }

        public override double getPerimeter()
        {
            return 2 * (length + width);
        }
    }
}
