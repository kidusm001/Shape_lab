using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Circle : Shape
    {
        private double radius;
        public double Radius { get { return radius; } set { radius = value; } } 
        public override double getArea()
        {
            return (3.14 * radius * radius);
        }
        public override double getPerimeter()
        {
            return (2 * 3.14 * radius);
        }
    }
}
