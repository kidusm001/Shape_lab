using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Triangle : Shape
    {
        //Triangle sides
        private double a;
        private double b;
        private double c;
        public double A { 
            get { return a; } 
            set { a = value; }
        
        }
        public double B
        {
            get { return b; }
            set { b = value; }

        }
        public double C
        {
            get { return c; }
            set { c = value; }

        }

        public override double getArea()
        {
            //semi-Perimeter
            double s = this.getPerimeter() / 2; 
            //Heron's Formula
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c)); 
        }

        public override double getPerimeter()
        {
            return (a + b + c);
        }
    }
}
