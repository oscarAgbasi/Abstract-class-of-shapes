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
    class Ellipse : twoDimensionalShape //inherting the 2d dimensional an abstract class
    {
        private double MajorAxis;
        private double minorAxis;
        public Ellipse() { SetData(); }

        public Ellipse(double Width, double Lenght) : base(Width, Lenght)
        {




        }

        public override double CalculateArea()
        {
            return Shape.PI * MajorAxis * minorAxis;
        }

        public override double CalculateVolume()
        {
            throw new NotImplementedException();
        }

        public override void SetData()
        {
            Console.WriteLine("Enter the major Axis:");
            MajorAxis = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the sminor Axis :");
            minorAxis = double.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return String.Format("This Shape is a elispe the MajorAxis " + MajorAxis + " and minorAxis " + minorAxis + " Area " + CalculateArea());
        }
    }
}
