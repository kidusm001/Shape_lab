using System;

namespace Shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int choice = p.menu();
            switch (choice)
            {
                case 0:
                    Console.WriteLine("No input \n");
                    break;
                case 1:
                    Console.WriteLine("Enter radius: \n");
                    double r = Console.Read();
                    Circle c = new Circle();
                    c.Radius = r;
                    double cArea= c.getArea();
                    double cPerimeter=c.getPerimeter();
                    Console.WriteLine("\nThe Area is: "+cArea);
                    Console.WriteLine("\nThe Perimeter: " + cPerimeter);

                    break;
                case 2:
                    Triangle t = new Triangle();
                    Console.WriteLine("\nEnter side 1:");
                    double s1 = Console.Read();
                    Console.WriteLine("\nEnter side 2:");
                    double s2 = Console.Read();
                    Console.WriteLine("\nEnter side 3:");
                    double s3 = Console.Read();
                    t.A=s1;
                    t.B=s2;
                    t.C = s3;
                    Console.WriteLine("\nThe Area is: "+t.getArea());
                    Console.WriteLine("\nThe Perimeter is: " + t.getPerimeter());
                    break;
                case 3:
                    Rectangle rec = new Rectangle();
                    Console.WriteLine("\nEnter lenght:");
                    double l=Console.Read();
                    Console.WriteLine("\nEnter Width:");
                    double w = Console.Read();
                    rec.Length=l;
                    rec.Width = w;
                    Console.WriteLine("\nThe Area is: " + rec.getArea());
                    Console.WriteLine("\nThe Perimeter is: " + rec.getPerimeter());
                    break;
                default:
                    Console.WriteLine("\nWrong Input");
                    break;
            }

            
        }
        int menu()
        {
            int choice=0;
            Console.WriteLine("Shape Menu: \n");
            Console.WriteLine("1.Circle \n");
            Console.WriteLine("2.Triangle \n");
            Console.WriteLine("3.Rectangle \n");
            Console.WriteLine("Choice a Shape: ");
            choice =int.Parse(Console.ReadLine());
            Console.WriteLine('\n');

            return choice;
        }

    }
}
