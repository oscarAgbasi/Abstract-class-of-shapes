/*
  Class:  Sphere.cs
  Author: Agbasi oscar
  Date:   September 4, 2017

  Purpose: This  class that inhertict method from the abstract class

           
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    class Cyclinder : threeDimensionalShape //inherting the 3d dimensional an abstract class
    {
        private double radius;
        private double height;

        public Cyclinder() { SetData(); }


        public Cyclinder(double Width, double Lenght, double Height, double radius) : base(Width, Lenght, Height)
        {



        }

        public override double CalculateArea()
        {
            return (2 * (Shape.PI) * (radius * radius)) + (2 * (Shape.PI) * (radius * height));
        }

        public override double CalculateVolume()
        {
            return Shape.PI * (2 * (radius) * height);
        }

        public override void SetData()
        {
            Console.WriteLine("Enter the radius : ");
            radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height : ");
            height = double.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return String.Format("This Shape is a cyclinder the height " + height + " and radius " + radius + " Area " + CalculateArea() + " Volume " + CalculateVolume());
        }
    }
}
