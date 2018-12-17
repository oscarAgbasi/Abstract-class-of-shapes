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
    class Circle : twoDimensionalShape //inherting the 2d dimensional an abstract class
    {
        private double radius;

        public Circle() { SetData(); }
        public Circle(double Width, double Lenght) : base(Width, Lenght)
        {




        }

        public override double CalculateArea()
        {
            return Shape.PI * (radius * radius);
        }

        public override double CalculateVolume()
        {
            return 0;
        }

        public override void SetData()
        {
            Console.WriteLine("Enter the radius : ");
            radius = double.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return String.Format("This Shape is a circle the radius " + radius + " Area " + CalculateArea());
        }



    }
}
